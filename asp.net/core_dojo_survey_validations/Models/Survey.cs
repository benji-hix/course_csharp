using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace core_dojo_survey_validations.Models;

public class Survey
{
    [Required(ErrorMessage="Name is required")]
    [MinLength(2, ErrorMessage ="Name must be at least 2 characters in length")]
    public string Name {get;set;}
    [Required]
    public string Location {get;set;}
    [Required]
    public string Language {get;set;}
    [MinLength(20, ErrorMessage ="Comment must be at least 20 characters if included")]
    public string? Comment {get;set;}
}