using System.Dynamic;
using Microsoft.Extensions.DependencyInjection;
using Shop.App.Data;
using Shop.App.Service;
using Shop.Domain.Entitys;
using Shop.Domain.Enums;

namespace Shop.App;

public class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection(); //Створюється контейнер DI (Dependency Injection)
        services.AddDbContext<ShopDbContext>(options =>DbConfigurator.Configure(options));
          
        //Створюється вже «працюючий» контейнер.
        var provider = services.BuildServiceProvider();

        //"Один DbContext на одну операцію роботи з БД"

        using var scope = provider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ShopDbContext>();

        if (context.Database.CanConnect())
        {
           Console.WriteLine("Пiдключення до БД встановлено");
      // service.CreateCategory(context);
       //   service.DeleteCategory(context); 
      // service.CreateProduct(context);

     // service.Registration(context);
        
     

        }
        else
        {
            Console.WriteLine("Не вдалось підключитись до БД");
        }
        
    }
}