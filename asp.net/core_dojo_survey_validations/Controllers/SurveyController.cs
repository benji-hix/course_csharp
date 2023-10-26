using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core_dojo_survey_validations.Models;

namespace core_dojo_survey_validations.Controllers;

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
        if(ModelState.IsValid)
        {
            survey = newForm;
            return RedirectToAction("Results");
        }

        else
        {
            return View("Form");
        }
    }

    [HttpGet("results")]
    public IActionResult Results()
    {
        return View(survey);
    }
}
