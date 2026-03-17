using Library.Domain.Entitys;

namespace Library.Domain;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }=string.Empty;
    public int TotalPages { get; set; }
    public decimal CostPrice { get; set; }
    public decimal SalesPrice { get; set; }
    public bool IsSeries { get; set; }
    public DateTime dataRelise{get;set;}
    public int? SeriesId { get; set; }
    public Series? Series { get; set; }
    public int? AuthorId { get; set; }
    public Author? Author { get; set; }
    public int? PublisherId { get; set; }
    public Publisher? Publisher { get; set; }
    public int TotalAmount{get;set;}
    public ICollection<BookDiscount> BookDiscounts { get; set; }=new List<BookDiscount>();
    
    public ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
    
}