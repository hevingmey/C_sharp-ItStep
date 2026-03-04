using Shop.App.Data;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection(); //Створюється контейнер DI (Dependency Injection)
        services.AddDbContext<ShopDbContext>(options =>DbConfigurator.Configure(options));
          
        //Створюється вже «працюючий» контейнер.
        var provider = services.BuildServiceProvider();

        //"Один DbContext на одну операцію роботи з БД"

        using var scope = provider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AcademyDbContext>();

        if (context.Database.CanConnect())
        {
            Console.WriteLine("Пiдключення до БД встановлено");
            User
        }
        else
        {
            Console.WriteLine("Не вдалось підключитись до БД");
        }
        
    }
}