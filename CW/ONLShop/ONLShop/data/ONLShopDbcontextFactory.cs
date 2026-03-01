using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ONLShop.Configurator;

namespace ONLShop.data;

public class ONLShopDbcontextFactory:IDesignTimeDbContextFactory<ONLShopDbcontext>
{
    public ONLShopDbcontext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ONLShopDbcontext>();
        DbConfigurator.Configure(optionsBuilder);
        return new ONLShopDbcontext(optionsBuilder.Options);
    }
    
}