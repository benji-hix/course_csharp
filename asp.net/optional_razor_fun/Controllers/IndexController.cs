using Microsoft.AspNetCore.Mvc;
namespace optional_razor_fun.Controllers;

public class IndexController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }
}