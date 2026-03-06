using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entitys;

namespace Shop.App.Data;

// public class CategoryProductConfiguration:IEntityTypeConfiguration<CategoryProduct>
// {
//     public void Configure(EntityTypeBuilder<CategoryProduct> builder)
//     {
//         builder.HasKey(x => new { x.ProductId, x.CategoryId });
//         
//         builder
//             .HasOne(cp => cp.Product)
//             .WithMany(p => p.CategoryProducts)
//             .HasForeignKey(cp => cp.ProductId);
//
//         builder
//             .HasOne(cp => cp.Category)
//             .WithMany(c => c.CategoryProducts)
//             .HasForeignKey(cp => cp.CategoryId);
//     }
// }
public class CategoryProduct
{
    [Key]
    public int Id { get; set; } 
    [ForeignKey(nameof(CategoryId))]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    [ForeignKey(nameof(ProductId))]
    public int ProductId { get; set; }
    public Products Products { get; set; }
    public int Store {get; set;}
    
}