using Academy.Context;
using Academy.Entitys;
using System.IO; 
using System;
using Academy.Configurator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Academy;

class Program
{
    static void Main(string[] args)
    {
        // var configuration = new ConfigurationBuilder()
        //     .SetBasePath(Directory.GetCurrentDirectory())
        //     .AddJsonFile("appsettings.json", optional: false, reloadOnChange:true)
        //     .Build();
        // var optionsBuilder = new DbContextOptionsBuilder<AcademyDbContext>();
        // optionsBuilder.UseSqlServer(configuration.GetConnectionString("firstConnection"));
        //
// Создаем контекст с этими опциями
            // using (var context = new AcademyDbContext(optionsBuilder.Options))
        {
            // Teacher teacher = new Teacher();
            // teacher.name = "John";
            // context.Teachers.Add(teacher);
            // context.SaveChanges();
            // var gr1 = context.Teachers.FirstOrDefault(t => t.name ==t.name);
            // Console.WriteLine(gr1.name);
            // Student st1 = new Student();
            // st1.name = "John";
            // st1.surname = "Doe";
            // context.Students.Add(st1);
            // context.SaveChanges();
            
            
 
        }
        // using (var Context=new AcademyDbContext())
        // {
        //     
        //      //Context.Database.EnsureCreated();
        //     Context.Database.EnsureDeleted();
        //      var user = new Student();
        //      Console.WriteLine("enter name");
        //      user.name = Console.ReadLine();
        //      Console.WriteLine("enter surname");
        //      user.surname =Console.ReadLine();
        //      Context.Students.Add(user);
        //      Context.SaveChanges();
        //      var Student=Context.Students.FirstOrDefault(st=>st.id==1);
        //      if (Student!=null)
        //      {
        //          Student.name = "Bob";
        //          Context.SaveChanges();
        //          Console.WriteLine($"name : {Student.name} {Student.surname}");
        //      }
        //     
        // }

            var services = new ServiceCollection(); //Створюється контейнер DI (Dependency Injection)
            services.AddDbContext<AcademyDbContext>(options =>DbConfigurator.Configure(options));
          
            //Створюється вже «працюючий» контейнер.
            var provider = services.BuildServiceProvider();

            //"Один DbContext на одну операцію роботи з БД"

            using var scope = provider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AcademyDbContext>();

            if (context.Database.CanConnect())
            {
                Console.WriteLine("Пiдключення до БД встановлено");
            }
            else
            {
                Console.WriteLine("Не вдалось підключитись до БД");
            }
     
        
    }
}