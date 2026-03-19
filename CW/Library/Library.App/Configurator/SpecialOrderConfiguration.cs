using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Library.Domain.Entitys;

namespace Library.App.data;

public class SpecialOrderConfiguration : IEntityTypeConfiguration<SpecialOrder>
{
    public void Configure(EntityTypeBuilder<SpecialOrder> builder)
    {
        builder.ToTable("SpecialOrders");

        builder.HasKey(x => x.Id);

       

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Book)
            .WithMany()
            .HasForeignKey(x => x.BookId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}