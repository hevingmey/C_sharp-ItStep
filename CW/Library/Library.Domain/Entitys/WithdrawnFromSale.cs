namespace Library.Domain.Entitys;

public class WithdrawnFromSale
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public DateTime Date { get; set; }
    public decimal PriceWas { get; set; }
    public string AuthorId { get; set; }
    public Author Author { get; set; }
}