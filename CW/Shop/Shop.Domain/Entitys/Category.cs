using System.ComponentModel.DataAnnotations;

namespace Shop.Domain.Entitys;


public class Category
{
   
    [Key] 
    public int Id { get; set; }
    [MaxLength(1000)] 
    [Required]
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

};