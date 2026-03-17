namespace Library.Domain.Entitys;

public class BookDiscount
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public decimal Discount { get; set; }
    
}