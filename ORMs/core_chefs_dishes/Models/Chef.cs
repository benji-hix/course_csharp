#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace core_chefs_dishes.Models;

public class Chef
{
    [Key]
    public int ChefId {get;set;}
    [Required(ErrorMessage="First Name is required")]
    public string FirstName {get;set;}
    [Required(ErrorMessage="Last Name is required")]
    public string LastName {get;set;}
    [ValidBirthDate]
    public DateTime? BirthDate {get;set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Dish> AllDishes {get;set;} = new List<Dish>();
}

public class ValidBirthDateAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("Birth Date is requried");
        }
        TimeSpan ageRaw = DateTime.Now.Subtract((DateTime)value);
        int age = (int)float.Parse(ageRaw.TotalDays.ToString()) / 365;
        if (age <18)
        {
            return new ValidationResult("Chef must be at least 18 years old");
        }
        if (DateTime.Compare((DateTime)value, DateTime.Now) >= 0)
        {
            return new ValidationResult("Please enter a valid Birth Date");
        } else {
            return ValidationResult.Success;
        }
    }
}