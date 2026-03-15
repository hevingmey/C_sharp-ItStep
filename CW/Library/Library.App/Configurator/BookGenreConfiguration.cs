using Microsoft.EntityFrameworkCore;
using Library.Domain.Entitys;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.App.data;

public class BookGenreConfiguration:IEntityTypeConfiguration<BookGenre>
{
    public void Configure(EntityTypeBuilder<BookGenre> builder)
    {
        builder.HasKey(x => new { x.BookId, x.GenreId });
        builder
            .HasOne(bg => bg.Book)
            .WithMany(b => b.BookGenres)
            .HasForeignKey(bg => bg.BookId);
        builder
            .HasOne(bg => bg.Genre)
            .WithMany(bg=>bg.BookGenres)
            .HasForeignKey(bg=>bg.GenreId);
    }
    
}