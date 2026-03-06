using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entitys;

namespace Shop.App.Data;

public class CategoryProductConfiguration:IEntityTypeConfiguration<CategoryProduct>
{
    public void Configure(EntityTypeBuilder<CategoryProduct> builder)
    {
        builder.HasKey(x => new { x.ProductId, x.CategoryId });
        
        builder
            .HasOne(cp => cp.Product)
            .WithMany(p => p.CategoryProducts)
            .HasForeignKey(cp => cp.ProductId);

        builder
            .HasOne(cp => cp.Category)
            .WithMany(c => c.CategoryProducts)
            .HasForeignKey(cp => cp.CategoryId);
    }
}
