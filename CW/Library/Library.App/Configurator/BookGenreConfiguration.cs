using Microsoft.EntityFrameworkCore;
using Library.Domain.Entitys;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.App.data;

public class BookGenreConfiguration:IEntityTypeConfiguration<BookGenre>
{
    public void Configure(EntityTypeBuilder<BookGenre> builder)
    {
        builder.HasKey(x => x.Id);
    }
    
}