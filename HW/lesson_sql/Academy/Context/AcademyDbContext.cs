using Academy.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Academy.Context;

public class AcademyDbContext:DbContext
{
    public DbSet<Student>Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(    "Server=localhost,1433;Database=MyAcademy;User Id=sa;Password=macAZUREnew!1390;TrustServerCertificate=True;"
        );
    }
}