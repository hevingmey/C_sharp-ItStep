using Library.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.App.data;

public class BookConfiguration:IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(x => x.Id);
        builder
            .HasOne(x => x.Author)
            .WithMany(x => x.Books)
            .HasForeignKey(y => y.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        
        builder
            .HasOne(x=>x.Publisher)
            .WithMany(x=>x.Books)
            .HasForeignKey(x=>x.PublisherId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasOne(x=>x.Series)
            .WithMany(x=>x.Books)
            .HasForeignKey(y=>y.SeriesId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}