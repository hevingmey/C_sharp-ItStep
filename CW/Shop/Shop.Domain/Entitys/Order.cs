using System.ComponentModel.DataAnnotations;
using Shop.Domain.Enums;

namespace Shop.Domain.Entitys;

public class Order
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public Users user { get; set; }
    public DateTime OrderDate { get; set; }= DateTime.Now;
    public int TotalAmount { get; set; }
    public StatusRole Status { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    
}