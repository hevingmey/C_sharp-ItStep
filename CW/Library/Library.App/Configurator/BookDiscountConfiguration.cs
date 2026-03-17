using Library.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.App.data;

public class BookDiscountConfiguration:IEntityTypeConfiguration<BookDiscount>
{
    public void Configure(EntityTypeBuilder<BookDiscount> builder)
    {
        builder.ToTable("BookDiscounts");
        builder.Property(x => x.BookId).IsRequired();
        builder.Property(x => x.Discount).IsRequired();
        
        builder
            .HasOne(x => x.Book)
            .WithMany(x => x.BookDiscounts)
            .HasForeignKey(x => x.BookId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}