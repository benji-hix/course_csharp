using Microsoft.AspNetCore.Mvc;
namespace intro.Controllers;

public class HelloController : Controller //* inheritance
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost("submit")]
    public string FormSubmission(string formInput)
    {
        return "I handled a request!";
    }
}