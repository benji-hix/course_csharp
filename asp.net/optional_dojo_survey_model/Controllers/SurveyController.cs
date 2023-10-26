using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using optional_dojo_survey_model.Models;

namespace optional_dojo_survey_model.Controllers;

public class SurveyController : Controller
{
    static Survey survey;
    
    private readonly ILogger<SurveyController> _logger;

    public SurveyController(ILogger<SurveyController> logger)
    {
        _logger = logger;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet("survey")]
    public IActionResult Form()
    {
        return View("Form");
    }

    [HttpPost("submit-form")]
    public IActionResult ProcessForm(Survey newForm)
    {
        survey = newForm;
        return RedirectToAction("Results");
    }

    [HttpGet("results")]
    public IActionResult Results()
    {
        return View(survey);
    }
}
