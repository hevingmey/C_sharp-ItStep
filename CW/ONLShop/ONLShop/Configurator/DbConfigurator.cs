namespace ONLShop.Configurator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
public class DbConfigurator
{
    public static void Configure(DbContextOptionsBuilder options)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        options.UseSqlServer(
            configuration.GetConnectionString("firstConnection"));
    }
}