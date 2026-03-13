using Library.Domain;
using Microsoft.EntityFrameworkCore;
using Library.Domain.Entitys;

namespace Library.App.data;

public class LibraryDbContext:DbContext
{
    public DbSet<BookGenre> BookGenres { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Genre> Genres { get; set; }
    
    public LibraryDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PublisherConfiguration());
        modelBuilder.ApplyConfiguration(new BookGenreConfiguration());
    }
}