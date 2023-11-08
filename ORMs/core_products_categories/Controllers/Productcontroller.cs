using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core_products_categories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing.Template;

namespace ProductController.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;
    private MyContext _context;

    public ProductController(ILogger<ProductController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    /* -------------------------------------------------------------------------- */
    /*                                  crud here                                 */
    /* -------------------------------------------------------------------------- */
    [HttpGet("products")]
    public IActionResult IndexProducts()
    {
        MyViewModel Models = new MyViewModel
        {
            ProductList = _context.Products.ToList()
        };
        return View("IndexProducts", Models);
    }

    [HttpPost("products/create")]
    public IActionResult CreateProduct(Product newProduct)
    {
        if(ModelState.IsValid)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("IndexProducts");
        }
        else 
        {
            MyViewModel Models = new MyViewModel
        {
            ProductList = _context.Products.ToList()
        };
            return View("IndexProducts", Models);
        }
    }

    [HttpGet("products/{id}")]
    public IActionResult ShowProduct(int id)
    {
        Product? product = _context.Products.Include(a => a.RelatedCategories).ThenInclude(a => a.Category).FirstOrDefault(p => p.ProductId == id);
        if (product == null)
        {
            return RedirectToAction("IndexProducts");
        }
        MyViewModel Models = new MyViewModel
        {
            Product = product
        };
        ViewBag.AvailableCategories = _context.Categories.Include(c => c.RelatedProducts).Where(c => c.RelatedProducts.All(p => p.ProductId != id)).ToList();
        ViewBag.ProductId = id;
        return View("ShowProduct", Models);
    }

    [HttpPost("products/{id}")]
    public IActionResult CreateProductAssociation(Association newAssociation, int id)
    {
        if (ModelState.IsValid)
        {
            _context.Associations.Add(newAssociation);
            _context.SaveChanges();
            return RedirectToAction("ShowProduct", new {id = id });
        } else {
            MyViewModel Models = new MyViewModel
            {
                    Product = _context.Products.Include(a => a.RelatedCategories).ThenInclude(a => a.Category).FirstOrDefault(p => p.ProductId == id)
            };
            ViewBag.AvailableCategories = _context.Categories.Include(c => c.RelatedProducts).Where(c => c.RelatedProducts.All(p => p.ProductId != id)).ToList();
            ViewBag.ProductId = id;
            return View("ShowProduct", Models);
        }
    }

    [HttpPost("products/{id}/destroy/{assocId}")]
    public IActionResult DestroyProductAssociation(int id, int assocId)
    {
        Association? AssocToDelete = _context.Associations.SingleOrDefault(a => a.AssociationId == assocId);
        if (AssocToDelete == null)
        {
            return RedirectToAction("ShowProduct", new {id = id});
        }

        _context.Associations.Remove(AssocToDelete);
        _context.SaveChanges();
        return RedirectToAction("ShowProduct", new {id = id});
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


