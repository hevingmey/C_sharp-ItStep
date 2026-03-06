using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Entitys;

// public class CategoryProduct
// {
//     public int Store { get; set; }
//     public int? CategoryId { get; set; }
//     public int? ProductId { get; set; }
//     public  Category? Category { get; set; }
//     public Products? Product { get; set; }
//     
// }
public class CategoryProduct
{
    [Key]
    public int Id { get; set; } 
    [ForeignKey(nameof(CategoryId))]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    [ForeignKey(nameof(ProductId))]
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Store {get; set;}
    
}