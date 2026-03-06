using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entitys;
namespace Shop.App.Data;

// public class OrderItemConfiguration:IEntityTypeConfiguration<OrderItem>
// {
//     public void Configure(EntityTypeBuilder<OrderItem> builder)
//     {
//         builder.HasKey(x => x.Id);
//         builder.ToTable("OrderItems");
//         builder.Property(x => x.Quantity).HasDefaultValue(0);
//         builder.Property(x => x.Price).HasPrecision(18, 2);
//         builder
//             .HasOne(x => x.Product)
//             .WithOne(x => x.OrderItem)
//             .HasForeignKey<OrderItem>(x => x.ProductId)
//             .OnDelete(DeleteBehavior.Restrict);
//     }
// }
public class OrderItem

{
    [Key] public int Id { get; set; }
    [ForeignKey(nameof(OrderId))]
    public int OrderId { get; set; }
    public Order Order { get; set; }
    [ForeignKey(nameof(ProductId))]
    public Products Products { get; set; }
  public int ProductId { get; set; }
    [Range(1,1000, ErrorMessage = "Quantity must be between 1 and 1000")]
    public int Quantity { get; set; }
    
};