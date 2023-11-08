using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core_chefs_dishes.Models;

namespace core_chefs_dishes.Controllers;

public class ChefController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public ChefController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("/chefs")]
    public IActionResult IndexChefs()
    {
        List<Chef> AllChefs = _context.Chefs.OrderBy(c => c.LastName).ToList();
        return View("IndexChefs", AllChefs);
    }

    [HttpGet("/chefs/new")]
    public IActionResult NewChef()
    {
        return View("NewChef");
    }

    [HttpPost("chefs/create")]
    public IActionResult CreateChef(Chef newChef)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("IndexChefs");
        }
        else 
        {
            return View("NewChef");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


