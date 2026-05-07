using Library.App.data;
using Library.App.Repositories;
using System.Text.Json.Serialization;
using Library.App.Services;
using Library.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LibraryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("firstConnection"));
});
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.SerializerOptions.WriteIndented = true;
});

builder.Services.AddScoped<BookRepository>();
builder.Services.AddScoped<BookSearchRepository>();

builder.Services.AddScoped<BookServices>();
builder.Services.AddScoped<BookSearchService>();

var app = builder.Build();


app.MapGet("/books", (BookServices service) =>
{
    var books = service.GetAllBooks();
    return Results.Ok(books);
});


app.MapGet("/books/{id}", (int id, BookServices service) =>
{
    var book = service.GetBookById(id);

    if (book == null)
        return Results.NotFound("Book not found");

    return Results.Ok(book);
});


app.MapPost("/books", (Book book, BookServices service) =>
{
    service.AddBookFromApi(book);

    return Results.Ok(book);
});


app.MapPut("/books/{id}", (int id, Book book, BookServices service) =>
{
    bool result = service.UpdateBookFromApi(id, book);

    if (result == false)
        return Results.NotFound("Book not found");

    return Results.Ok("Book updated");
});


app.MapDelete("/books/{id}", (int id, BookServices service) =>
{
    bool result = service.DeleteBookById(id);

    if (result == false)
        return Results.NotFound("Book not found");

    return Results.Ok("Book deleted");
});


app.MapGet("/books/search/title", (string title, BookSearchService service) =>
{
    var books = service.SearchByTitle(title);

    return Results.Ok(books);
});


app.MapGet("/books/search/author", (string authorName, BookSearchService service) =>
{
    var books = service.SearchByAuthor(authorName);

    return Results.Ok(books);
});

app.Run();