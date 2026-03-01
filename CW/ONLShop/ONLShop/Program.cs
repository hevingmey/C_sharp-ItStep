using Microsoft.Extensions.DependencyInjection;
using ONLShop.Entitys;
using System;
using Microsoft.EntityFrameworkCore;
using ONLShop.metods;
using ONLShop.Configurator;
using ONLShop.data;
namespace ONLShop;

class Program
{
    static void Main(string[] args)
    {
       
        var services = new ServiceCollection(); //Створюється контейнер DI (Dependency Injection)
        services.AddDbContext<ONLShopDbcontext>(options =>DbConfigurator.Configure(options));
      
        //Створюється вже «працюючий» контейнер.
        var provider = services.BuildServiceProvider();

        //"Один DbContext на одну операцію роботи з БД"

        using var scope = provider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ONLShopDbcontext>();

        if (context.Database.CanConnect())
        {
            Console.WriteLine("Пiдключення до БД встановлено");
        }
        else
        {
            Console.WriteLine("Не вдалось підключитись до БД");
        }
        
        // використана окрема папка де зберіг методи 
      
        Metod.CreateProduct(context);
        Metod.showProductsFromCateg(context);
        
    }
}