using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Shop.Domain.Entitys;


public class OrderItem

{
    [Key] 
    public int Id { get; set; } 
    [ForeignKey(nameof(Order))]
    public int OrderId { get; set; }

   
    public Order Order { get; set; } = null!;
   [ForeignKey(nameof(Product))] 
    public int ProductId { get; set; }
   
    public Product Product { get; set; } = null!;
    
    [Range(1,1000, ErrorMessage = "Quantity must be between 1 and 1000")]
    public int Quantity { get; set; }
    public decimal Price { get; set; } 
    
};