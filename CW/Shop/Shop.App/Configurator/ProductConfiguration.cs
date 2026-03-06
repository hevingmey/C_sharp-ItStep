using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entitys;
namespace Shop.App.Data;

public class ProductConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
        builder.ToTable("Products");
        builder.ToTable(p => p.HasCheckConstraint("Check_prodName", "Len([Name])>=2"));
        
        
    }
}

    
   
    
