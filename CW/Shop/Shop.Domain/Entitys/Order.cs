namespace Shop.Domain.Entitys;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public Users User { get; set; }
    public DateTime OrderDate { get; set; }
    public int TotalAmount  { get; set; }
    public int Staus { get; set; }
    
}