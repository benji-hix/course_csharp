using Microsoft.AspNetCore.Mvc;
namespace intro.Controllers;

public class HelloController : Controller //* inheritance
{
    [HttpGet("hello/{name}")]
    public string Index(string name)
    {
        return $"Hello {name}!";
    }

    [HttpPost("submit")]
    public string FormSubmission(string formInput)
    {
        return "I handled a request!";
    }
}