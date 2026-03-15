using System.ComponentModel.DataAnnotations;

namespace Shop.Domain.Entitys;


public class Product
{
     public int Id { get; set; }
     public int Store { get; set; }

    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public decimal Price { get; set; }
     public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
     public ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();
};