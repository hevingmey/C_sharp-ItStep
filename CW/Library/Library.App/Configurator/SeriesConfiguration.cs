using Library.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.App.data;

public class SeriesConfiguration:IEntityTypeConfiguration<Series>
{
    public void Configure(EntityTypeBuilder<Series> builder)
    {
        builder.HasKey(x=>x.Id);
       builder.HasIndex(x=>x.Name).IsUnique();
       builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
     
    }
}