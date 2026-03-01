using Academy.Configurator;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Academy.Context;


public class AcademyDbContextFactory
    : IDesignTimeDbContextFactory<AcademyDbContext>

{
    public AcademyDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AcademyDbContext>();

        DbConfigurator.Configure(optionsBuilder);

        return new AcademyDbContext(optionsBuilder.Options);
        
    }
    
}