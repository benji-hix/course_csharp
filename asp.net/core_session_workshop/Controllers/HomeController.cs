using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core_session_workshop.Models;

namespace core_session_workshop.Controllers;

public class HomeController : Controller
{
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("submit-form")]
    public IActionResult ProcessForm(string Name = "")
    {
         if (Name=="") {
            return View("Index");
         }
         else {
            HttpContext.Session.SetString("UserName", Name);
            HttpContext.Session.SetInt32("DisplayNum", 22);
            return RedirectToAction("Calculator");
         }
    }

    [HttpGet("calculator")]
    public IActionResult Calculator()
    {
        return View();
    }

    [HttpGet("math/+1")]
    public IActionResult PlusOne()
    {
        int? num = HttpContext.Session.GetInt32("DisplayNum");
        num += 1;
        HttpContext.Session.SetInt32("DisplayNum", (int)num);
        return RedirectToAction("Calculator");
    }
    
    [HttpGet("math/-1")]
    public IActionResult MinusOne()
    {
        int? num = HttpContext.Session.GetInt32("DisplayNum");
        num -= 1;
        HttpContext.Session.SetInt32("DisplayNum", (int)num);
        return RedirectToAction("Calculator");
    }

    [HttpGet("math/x2")]
    public IActionResult TimesTwo()
    {
        int? num = HttpContext.Session.GetInt32("DisplayNum");
        num *= 2;
        HttpContext.Session.SetInt32("DisplayNum", (int)num);
        return RedirectToAction("Calculator");
    }

    [HttpGet("math/+random")]
    public IActionResult PlusRandom()
    {
        Random rand = new Random();
        int? num = HttpContext.Session.GetInt32("DisplayNum");
        num += rand.Next(1, 11);
        HttpContext.Session.SetInt32("DisplayNum", (int)num);
        return RedirectToAction("Calculator");
    }

    [HttpGet("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
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
