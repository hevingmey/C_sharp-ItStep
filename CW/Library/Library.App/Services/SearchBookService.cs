using Library.App.Repositories;
using Library.Domain;
using Library.Domain.Entitys;

namespace Library.App.Services;

public class BookSearchService
{
    private readonly BookSearchRepository _repository;

    public BookSearchService(BookSearchRepository repository)
    {
        _repository = repository;
    }

    public List<Book> SearchByTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new Exception("title is empty");

        return _repository.SearchByTitle(title);
    }

    public List<Book> SearchByAuthor(string authorName)
    {
        if (string.IsNullOrWhiteSpace(authorName))
            throw new Exception("author name is empty");

        return _repository.SearchByAuthor(authorName);
    }

    public List<Book> SearchByGenre(string genreName)
    {
        if (string.IsNullOrWhiteSpace(genreName))
            throw new Exception("genre name is empty");

        return _repository.SearchByGenre(genreName);
    }

    public List<Book> GetNewBooks()
    {
        return _repository.GetNewBooks();
    }
}