using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ONLShop.Entitys;
namespace ONLShop.data;

public class ONLShopDbcontext:DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public ONLShopDbcontext(DbContextOptions<ONLShopDbcontext> options):base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);
        
    }
}
