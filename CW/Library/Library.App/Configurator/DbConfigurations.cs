using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;
namespace Library.App.data;

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