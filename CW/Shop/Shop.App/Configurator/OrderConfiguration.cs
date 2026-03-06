using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entitys;
namespace Shop.App.Data;

// public class OrderConfiguration:IEntityTypeConfiguration<Order>
// {
//     public void Configure(EntityTypeBuilder<Order> builder)
//     {
//         builder.HasKey(x => x.Id);
//         builder.ToTable("Orders");
//         builder.Property(x => x.TotalAmount).HasPrecision(18, 2);
//         builder.Property(x => x.OrderDate).HasDefaultValueSql("getdate()");
//         
//     }
// }

public class Order
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public  Users User { get; set; }
    
}