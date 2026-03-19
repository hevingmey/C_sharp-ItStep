using Library.App.data;
using Library.Domain;
using Library.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Library.App.Repositories;

public class BookSearchRepository
{
    private readonly LibraryDbContext _context;

    public BookSearchRepository(LibraryDbContext context)
    {
        _context = context;
    }

    public List<Book> SearchByTitle(string title)
    {
        return _context.Books
            .Include(b => b.Author)
            .Include(b => b.Genre)
            .Include(b => b.Publisher)
            .Where(b => b.Name.ToLower().Contains(title.ToLower()))
            .ToList();
    }

    public List<Book> SearchByAuthor(string authorName)
    {
        return _context.Books
            .Include(b => b.Author)
            .Include(b => b.Genre)
            .Include(b => b.Publisher)
            .Where(b => b.Author.FullName.ToLower().Contains(authorName.ToLower()))
            .ToList();
    }

    public List<Book> SearchByGenre(string genreName)
    {
        return _context.Books
            .Include(b => b.Author)
            .Include(b => b.Genre)
            .Include(b => b.Publisher)
            .Where(b => b.Genre.Name.ToLower().Contains(genreName.ToLower()))
            .ToList();
    }

    public List<Book> GetNewBooks()
    {
        return _context.Books
            .Include(b => b.Author)
            .Include(b => b.Genre)
            .Include(b => b.Publisher)
            .Where(b => b.dataRelise >= DateTime.Now.AddMonths(-1))
            .OrderByDescending(b => b.dataRelise)
            .ToList();
    }
}