using Library.App.data;
using Library.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Domain.Entitys;

namespace Library.App.Repositories;

public class BookRepository
{
    private LibraryDbContext _context;

    public BookRepository(LibraryDbContext context)
    {
        _context = context;
    }

    public void DeleteBook(int id)
    {
        var  book = _context.Books.Find(id);
        if (book != null)
        {

            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }

    public void addBook(Book book)
    {
        _context.Add(book);
        _context.SaveChanges();
    }

    public void updateBookName(string name, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.Name = name;
        _context.SaveChanges();
    }

    public void updateBookTotalPages(int pages, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.TotalPages = pages;
        _context.SaveChanges();
    }

    public void updateBookCostPrice(decimal cost, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.CostPrice = cost;
        _context.SaveChanges();
    }

    public void updateBookSalesPrice(decimal sales, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.SalesPrice = sales;
        _context.SaveChanges();
    }

    public void updateBookIsbn(bool isseries, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.IsSeries = isseries;
        _context.SaveChanges();
    }

    public void updateBookAuthor(int aId, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.AuthorId = aId;
        _context.SaveChanges();
    }

    public void updateBookPublisher(int pId, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.PublisherId = pId; 
        _context.SaveChanges();
    }

    public void updateBookDate(DateTime date, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.dataRelise = date;
        _context.SaveChanges();
    }

    public List<Book> GetBooks()
    {
        return _context.Books.ToList();
    }
}