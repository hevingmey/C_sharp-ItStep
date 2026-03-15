namespace Library.Domain.Entitys;

public class Publisher
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    
    

    public ICollection<Book> Books { get; set; } = new List<Book>();
}