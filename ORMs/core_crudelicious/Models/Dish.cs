#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace core_crudelicious.Models;

public class Dish
{
    [Key]
    public int DishID {get;set;}
    [Required(ErrorMessage="Dish name is required")]
    public string Name {get;set;}
    [Required(ErrorMessage="Chef name is required")]
    public string Chef {get;set;}
    [Required(ErrorMessage="Tastiness is required")]
    [Range(1, 5, ErrorMessage ="Tastiness must be between 1 and 5")]
    public int Tastiness {get;set;}
    [Required(ErrorMessage="Calories is required")]
    [GreaterThanZero]
    public int Calories {get;set;}
    [Required(ErrorMessage="Description is required")]
    public string Description {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now; 
}

public class GreaterThanZeroAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if ((int)value < 1)
        {
            return new ValidationResult("Calories must be greater than 0");
        }
        else {
            return ValidationResult.Success;
        }
    }
}