using Microsoft.AspNetCore.Mvc;
namespace optional_countdown.Controllers;

public class CountdownController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        DateTime EndDate = new DateTime(2023, 11, 24, 7, 30, 0);
        DateTime CurrentDate = DateTime.Now;
        TimeSpan TimeDiff = EndDate.Subtract(CurrentDate);
        ViewBag.EndDate = EndDate;
        ViewBag.TimeDiff = TimeDiff;
        ViewBag.Test = 5;
        return View();
    }
}