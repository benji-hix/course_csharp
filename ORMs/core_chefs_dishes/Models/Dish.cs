#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace core_chefs_dishes.Models;

public class Dish
{
    [Key]
    public int DishId {get;set;}
    [Required(ErrorMessage ="Chef is required")]
    public int ChefId {get;set;}
    [Required(ErrorMessage="Dish name is required")]
    public string Name {get;set;}
    [Required(ErrorMessage="Tastiness is required")]
    [Range(1, 5, ErrorMessage ="Tastiness must be between 1 and 5")]
    public int Tastiness {get;set;}
    [ValidateCalories]
    public int? Calories {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now; 

    public Chef? Creator {get; set;}
}

public class ValidateCaloriesAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("Calories is required");
        }
        if ((int)value < 1)
        {
            return new ValidationResult("Calories must be greater than 0");
        }
        else {
            return ValidationResult.Success;
        }
    }
}