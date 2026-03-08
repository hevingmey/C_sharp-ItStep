using System.ComponentModel.DataAnnotations;

namespace Shop.Domain.Entitys;


public class Product
{
    [Key] public int Id { get; set; }
    [MaxLength(1000)] 
    [Required]
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Range(0.1, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
    public decimal Price { get; set; }
     public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
     public ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();
};