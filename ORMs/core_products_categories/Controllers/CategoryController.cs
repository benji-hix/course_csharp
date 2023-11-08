using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core_products_categories.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryController.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;
    private MyContext _context;

    public CategoryController(ILogger<CategoryController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    /* -------------------------------------------------------------------------- */
    /*                                  crud here                                 */
    /* -------------------------------------------------------------------------- */
    [HttpGet("categories")]
    public IActionResult IndexCategories()
    {
        MyViewModel Models = new MyViewModel
        {
            CategoryList = _context.Categories.ToList()
        };
        return View("IndexCategories", Models);
    }

    [HttpPost("categories/create")]
    public IActionResult CreateCategory(Category newCategory)
    {
        if(ModelState.IsValid)
        {
            _context.Categories.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction("IndexCategories");
        }
        else 
        {
            MyViewModel Models = new MyViewModel
        {
            CategoryList = _context.Categories.ToList()
        };
            return View("IndexCategories", Models);
        }
    }

    [HttpGet("categories/{id}")]
    public IActionResult ShowCategory(int id)
    {   
        Category? category = _context.Categories.Include(a => a.RelatedProducts).ThenInclude(a => a.Product).FirstOrDefault(c => c.CategoryId == id);
        if (category == null)
        {
            return RedirectToAction("IndexCategories");
        }
        MyViewModel Models = new MyViewModel
        {
                Category = category
        };
        ViewBag.AvailableProducts = _context.Products.Include(p => p.RelatedCategories).Where(p => p.RelatedCategories.All(c => c.CategoryId != id)).ToList();
        ViewBag.CategoryId = id;
        return View("ShowCategory", Models);
    }

    [HttpPost("categories/{id}")]
    public IActionResult CreateCategoryAssociation(Association newAssociation, int id)
    {
        if (ModelState.IsValid)
        {
            _context.Associations.Add(newAssociation);
            _context.SaveChanges();
            return RedirectToAction("ShowCategory", new {id = id});
        } else {
            MyViewModel Models = new MyViewModel
            {
                    Category = _context.Categories.Include(a => a.RelatedProducts).ThenInclude(a => a.Product).FirstOrDefault(c => c.CategoryId == id)
            };
            ViewBag.AvailableProducts = _context.Products.Include(p => p.RelatedCategories).Where(p => p.RelatedCategories.All(c => c.CategoryId != id)).ToList();
            ViewBag.CategoryId = id;
            return View("ShowCategory", Models);
        }
    }

    [HttpPost("categories/{id}/destory/{assocId}")]
    public IActionResult DestroyCategoryAssociation(int id, int assocId)
    {
        Association? AssocToDelete = _context.Associations.SingleOrDefault(a => a.AssociationId == assocId);
        if (AssocToDelete == null)
        {
            return RedirectToAction("ShowCategory", new {id = id});
        }

        _context.Associations.Remove(AssocToDelete);
        _context.SaveChanges();
        return RedirectToAction("ShowCategory", new {id = id});
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


