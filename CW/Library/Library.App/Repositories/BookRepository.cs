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
        var book = _context.Books.Find(id);
        if (book != null)
        {

            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }

    public void AddBookToDiscount(int bookDiscountId, decimal discount)
    {var book = _context.Books.Find(bookDiscountId);
        if (book == null)
            throw new Exception("Book not found");
            
        var bokdiscount = new BookDiscount
        {
            BookId = bookDiscountId,
            Discount =book.SalesPrice-(book.SalesPrice * discount/100m)
        };
        _context.BookDiscounts.Add(bokdiscount);
        _context.SaveChanges();
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
    }

    public void updateBookTotalPages(int pages, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.TotalPages = pages;
    }

    public void updateBookCostPrice(decimal cost, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.CostPrice = cost;
    }

    public void updateBookSalesPrice(decimal sales, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.SalesPrice = sales;
    }

    public void updateBookIsbn(bool isseries, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.IsSeries = isseries;
    }

    public void updateBookAuthor(int aId, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.AuthorId = aId;
    }

    public void updateBookPublisher(int pId, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.PublisherId = pId;
     
    }

    public void updateBookDate(DateTime date, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.dataRelise = date;
        
    }

    public void UpdateBookTotalAmount(int totalamount, int id)
    {
        var bookToUpdate = _context.Books.Find(id);
        bookToUpdate.TotalAmount = totalamount;
       
    }

    public List<Book> GetBooks()
    {
        return _context.Books.ToList();
    }
 
    public  Book GetBookId(int id)
    {
        return _context.Books.Find(id);
    }
    
}
