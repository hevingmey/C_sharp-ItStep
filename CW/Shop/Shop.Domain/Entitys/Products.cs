namespace Shop.Domain.Entitys;

public class Products
{
    public int  Id { get; set; }
    public string Name { get; set; }=string.Empty;
    public int Store { get; set; }

    public decimal Price { get; set; }
    public OrderItem OrderItem { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public ICollection<CategoryProduct> CategoryProducts { get; set; }=new List<CategoryProduct>();

}