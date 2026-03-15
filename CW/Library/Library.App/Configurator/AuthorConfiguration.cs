using Library.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.App.data;

public class AuthorConfiguration:IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.FullName).IsUnique();


    }
}