using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core_crudelicious.Models;
using System.Diagnostics.CodeAnalysis;

namespace core_crudelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("/dishes")]
    public IActionResult Index()
    {
        List<Dish> AllDishes = _context.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
        ViewBag.AllDishes = AllDishes;
        return View();
    }

    [HttpGet("dishes/new")]
    public IActionResult NewDish()
    {
        return View("NewDish");
    }

    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else 
        {
            return View("NewDish");
        }
    }

    [HttpGet("dishes/{id}")]
    public IActionResult ShowDish(int id)
    {
        ViewBag.Dish = _context.Dishes.FirstOrDefault(d => d.DishID == id);
        return View("ShowDish");
    }

    [HttpGet("dishes/{id}/edit")]
    public IActionResult EditDish(int id)
    {
        Dish? OldDish = _context.Dishes.FirstOrDefault(d=> d.DishID == id);
        if (OldDish == null)
        {
            return RedirectToAction("Index");
        }
        return View("EditDish", OldDish);
    }

    [HttpPost("dishes/{id}/update")]
    public IActionResult UpdateDish(Dish EditedDish, int id)
    {
        Dish? OldDish = _context.Dishes.FirstOrDefault(d=> d.DishID == id);
        if (OldDish == null)
        {
            return RedirectToAction("Index");
        }

        if (ModelState.IsValid)
        {

            OldDish.Name = EditedDish.Name;
            OldDish.Chef = EditedDish.Chef;
            OldDish.Tastiness = EditedDish.Tastiness;
            OldDish.Calories = EditedDish.Calories;
            OldDish.Description = EditedDish.Description;
            OldDish.UpdatedAt = DateTime.Now;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        else {
            return View("EditDish", OldDish);
        }
    }

    [HttpPost("dishes/{id}/destroy")]
    public IActionResult DestroyDish(int id)
    {
        Dish? DishToDelete = _context.Dishes.SingleOrDefault(d => d.DishID == id);
        if (DishToDelete == null)
        {
            return RedirectToAction("Index");
        }

        _context.Dishes.Remove(DishToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
