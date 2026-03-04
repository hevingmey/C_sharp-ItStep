namespace Shop.Domain.Entitys;

public class CategoryProduct
{
    public int Store { get; set; }
    public int? CategoryId { get; set; }
    public int? ProductId { get; set; }
    public  Category? Category { get; set; }
    public Products? Product { get; set; }
    
}