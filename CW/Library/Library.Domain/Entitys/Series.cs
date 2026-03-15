namespace Library.Domain.Entitys;

public class Series
{
    public int Id { get; set; }
   public string Name { get; set; }
   public ICollection<Book> Books { get; set; }

}