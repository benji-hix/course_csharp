using Microsoft.AspNetCore.Mvc;
namespace core_dojo_survey.Controllers;

public class SurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Form()
    {
        return View();
    }

    [HttpPost("submit-form")]
    public IActionResult FormSubmit(string FormName, string FormLocation, 
    string FormLanguage, string FormComment  = "")
    {
        return RedirectToAction("Results", new {name = FormName, location = FormLocation, language = FormLanguage, comment = FormComment});
    }

    [HttpGet("results/name/location/language/comment")]
    public ViewResult Results(string name, string location, string language, string comment = "")
    {
        ViewBag.Name = name;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.Comment = comment;
        return View();
    }
}