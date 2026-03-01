using Academy.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Academy.Context;

public class AcademyDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Curators> Curators { get; set; }

    public AcademyDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        modelBuilder.Entity<Student>()
            .HasOne(s=>s.group)
            .WithMany(g=>g.Students)
            .HasForeignKey(s=>s.groupId);
        
        modelBuilder.Entity<Subject>()
            .Property(s => s.Name)
            .HasMaxLength(100)
            .IsRequired();
        
         modelBuilder.Entity<Grade>()
                    .HasCheckConstraint("CK_Grade_Value","[Value] between 1 and 12");
         
                 modelBuilder.Entity<Grade>()
                     .HasOne(g=>g.subject)
                     .WithMany(s=>s.Grades)
                     .HasForeignKey(g=>g.subjectId);
                 
                 modelBuilder.Entity<Grade>()
                     .HasOne(g=>g.student)
                     .WithMany(s=>s.Grades)
                     .HasForeignKey(g=>g.studentId);
                 
                 
                 
                //була обʼєднана
            // modelBuilder.Entity<Student>()
            //     .HasMany(s => s.courses)
            //     .WithMany(c=>c.students)
            //     .UsingEntity(j=>j.ToTable("Grade"));
                
            
       
        
        
    }
}


