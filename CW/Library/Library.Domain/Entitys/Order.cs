namespace Library.Domain.Entitys;

public class Order
{
    public int id { get; set; }
    public List<Book> books { get; set; } = new();
}