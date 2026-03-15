using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
namespace Library.App.data;

public class LibraryDbContextFactory: IDesignTimeDbContextFactory<LibraryDbContext>

    

    {
        public LibraryDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LibraryDbContext>();

            DbConfigurator.Configure(optionsBuilder);

            return new LibraryDbContext(optionsBuilder.Options);
        
        }
    
    }
