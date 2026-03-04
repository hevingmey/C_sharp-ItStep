using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
namespace Shop.App.Data;

public class ShopDbContextFactory: IDesignTimeDbContextFactory<ShopDbContext>

    

    {
        public ShopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ShopDbContext>();

            DbConfigurator.Configure(optionsBuilder);

            return new ShopDbContext(optionsBuilder.Options);
        
        }
    
    }
