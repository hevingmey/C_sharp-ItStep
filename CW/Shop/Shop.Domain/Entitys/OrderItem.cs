using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Shop.Domain.Entitys;


public class OrderItem

{
    
    public int Id { get; set; } 
    public int OrderId { get; set; }

   
    public Order Order { get; set; } = null!;
    public int ProductId { get; set; }
   
    public Product Product { get; set; } = null!;
    

    public int Quantity { get; set; }
    public decimal Price { get; set; } 
    
};