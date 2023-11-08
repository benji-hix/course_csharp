#pragma warning disable CS8618
namespace core_products_categories.Models;

public class MyViewModel
{
    public Category? Category {get;set;}
    public List<Category> CategoryList {get;set;}
    public Product? Product {get;set;}
    public List<Product> ProductList {get;set;}
    public Association Association {get;set;}
    public List<Association> AssociationList {get;set;}
}