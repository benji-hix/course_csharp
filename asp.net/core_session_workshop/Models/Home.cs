using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace core_session_workshop.Models;

public class Home
{
    [Required(ErrorMessage ="Name is required")]
    [MinLength(2, ErrorMessage = "Name mus tbe at least 2 characters")]
    public string Name {get;set;}
}