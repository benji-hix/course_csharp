#pragma warning disable CS8618
using core_chefs_dishes.Models;
using Microsoft.EntityFrameworkCore;
namespace core_chefs_dishes.Models;
public class MyContext : DbContext 
{   
    public MyContext(DbContextOptions options) : base(options) { }    
    public DbSet<Dish> Dishes { get; set; } 
    public DbSet<Chef> Chefs {get;set;}
}