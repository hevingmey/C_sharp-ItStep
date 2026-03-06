using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entitys;
using Shop.Domain.Enums;

namespace Shop.App.Data;

// public class ConfigurationUser:IEntityTypeConfiguration<Users>
// {
//     public void Configure(EntityTypeBuilder<Users> builder)
//     {
//         builder.HasKey(x => x.Id);
//         builder.HasIndex(x => x.Email).IsUnique();
//         builder.ToTable(s => s.HasCheckConstraint("rolleCheck", "[Role] In (0,1,2,3)"));
//         builder.ToTable(s=>s.HasCheckConstraint("Check_surname","Len([surname])>=1"));
//         builder.Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");
//
//     }
//     
// }

public class User
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
    public DateTime CreatedAt { get; set; }
}