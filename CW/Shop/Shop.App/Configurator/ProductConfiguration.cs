using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entitys;
namespace Shop.App.Data;

// public class ProductConfiguration:IEntityTypeConfiguration<Products>
// {
//     public void Configure(EntityTypeBuilder<Products> builder)
//     {
//         // builder.HasKey(x => x.Id);
//         // builder.Property(x => x.Name).IsRequired();
//         // builder.ToTable("Products");
//         // builder.ToTable(p => p.HasCheckConstraint("Check_prodName", "Len([Name])>=2"));
//         //
//         
//     }
// }
public class Products
{
    [Key] public int Id { get; set; }
    [MaxLength(1000)] 
    [Required]
    public string Name { get; set; }

    [Range(0.1, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
    public decimal Price { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
    public ICollection<CategoryProduct> CategoryProducts { get; set; }
};
    
   
    
