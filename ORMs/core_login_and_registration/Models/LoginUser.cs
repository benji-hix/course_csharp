#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace core_login_and_registration.Models;

public class LoginUser
{
    [Required(ErrorMessage = "Email is required")]    
    [EmailAddress]
    public string LoginEmail { get; set; }    
    [Required(ErrorMessage = "Password is required")]    
    public string LoginPassword { get; set; } 
}
