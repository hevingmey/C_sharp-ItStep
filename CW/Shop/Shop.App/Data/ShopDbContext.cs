using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entitys;

namespace Shop.App.Data;

public class ShopDbContext:DbContext
{
    public DbSet<Category> Category { get; set; }
    public DbSet<Users>  Users { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<CategoryProduct> CategoryProducts { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    
    public ShopDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new ConfigurationUser());
        // modelBuilder.ApplyConfiguration(new CategoryProductConfiguration());
    }
}