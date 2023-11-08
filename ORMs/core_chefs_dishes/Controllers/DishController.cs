using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core_chefs_dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace core_chefs_dishes.Controllers;

public class DishController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public DishController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("/dishes")]
    public IActionResult IndexDishes()
    {
        List<Dish> AllDishes = _context.Dishes.Include(d => d.Creator).ToList();
        return View("IndexDishes", AllDishes);
    }
    
    [HttpGet("/dishes/new")]
    public IActionResult NewDish()
    {
        ViewBag.AllChefs = _context.Chefs.OrderBy(c => c.LastName).ToList();
        return View("NewDish");
    }

    [HttpPost("/dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Dishes.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("IndexDishes");
        }
        else 
        {
            ViewBag.AllChefs = _context.Chefs.OrderBy(c => c.LastName).ToList();
            return View("NewDish");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


