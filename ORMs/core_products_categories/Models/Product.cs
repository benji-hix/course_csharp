#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace core_products_categories.Models;
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required(ErrorMessage ="Name is required")]
    public string Name {get;set;}
    [Required(ErrorMessage ="Description is required")]
    public string Description {get;set;}
    [Required(ErrorMessage ="Price is required")]
    public float? Price {get;set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Association> RelatedCategories {get;set;} = new List<Association>();
}
