using Academy.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Academy.Context;

public class AcademyDbContext:DbContext
{
    public DbSet<Student>Students { get; set; }
    public DbSet<Teacher>Teachers { get; set; }

    public AcademyDbContext(DbContextOptions options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        // modelBuilder.Entity<Student>()
        //     .HasOne(s => s.Group)
        //     .WithMany(g => g.Group)
        //     .HasForeignKey(s => s.groupId);

    }

// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     base.OnConfiguring(optionsBuilder);
    //     optionsBuilder.UseSqlServer(    "Server=localhost,1433;Database=MyAcademy;User Id=sa;Password=macAZUREnew!1390;TrustServerCertificate=True;"
    //     );
    // }
