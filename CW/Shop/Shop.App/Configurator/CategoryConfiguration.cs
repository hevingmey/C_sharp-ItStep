using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entitys;
namespace Shop.App.Data;

// public class CategoryConfiguration:IEntityTypeConfiguration<Category>
// {
//     public void Configure(EntityTypeBuilder<Category> builder)
//     {
//         builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
//         builder.HasIndex(x => x.Name).IsUnique();
//         builder.ToTable("Categories",c => c.HasCheckConstraint("Check_catgrName", "Len([Name])>=2"));
//     
//         
//     }
//     
// }

public class Category
{
   
    [Key] 
    public int Id { get; set; }
    [MaxLength(1000)] 
    [Required]
    public string Name { get; set; }
    public ICollection<CategoryProduct> CategoryProducts { get; set; }

};