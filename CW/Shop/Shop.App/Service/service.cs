using Shop.App.Data;
using Shop.Domain.Entitys;
using Shop.Domain.Enums;

namespace Shop.App.Service;

public class service
{
    public static void CreateOrder(ShopDbContext context)
    {
        Console.WriteLine("enter user id");
        int userId = int.Parse(Console.ReadLine());
        Console.WriteLine("status");
        int status = int.Parse(Console.ReadLine());
        var createOrder = new Order
        {
            UserId = userId,
            Status = (StatusRole)status
        };
        context.Add(createOrder);
        context.SaveChanges();
        Console.WriteLine("Order created");
    }

    public static void Registration(ShopDbContext context)
    {
        Console.WriteLine("enter name user: ");
        string name = Console.ReadLine();
        Console.WriteLine("enter surname user: ");
        string surname = Console.ReadLine();
        Console.WriteLine("enter email user: ");
        string email = Console.ReadLine();
        Console.WriteLine("enter password: ");
        string password = Console.ReadLine();
        Console.WriteLine("enter role: ");
        int role = int.Parse(Console.ReadLine());
        var person = new Users
        {
            Name = name,
            Surname = surname,
            Email = email,
            HashPassword = password,
            Role = (UserRole)role,

        };
        context.Add(person);
        context.SaveChanges();
        Console.WriteLine("User created");
    }

    public static void CreateProduct(ShopDbContext context)
    {
        Console.WriteLine("enter name product: ");
        string name = Console.ReadLine();
        Console.WriteLine("enter price: ");
        decimal price = decimal.Parse(Console.ReadLine());
      
        var product = new Product
        {
            Name = name,
            Price = price,
        };
        context.Add(product);
        context.SaveChanges();
        Console.WriteLine("Product created");
    }

    public static void CreateCategory(ShopDbContext context)
    {
        Console.WriteLine("enter name category: ");
        string name = Console.ReadLine();
        var category = new Category
        {
            Name = name,

        };
        context.Add(category);
        context.SaveChanges();
        Console.WriteLine("Category created");
        
    }

    public static void DeleteCategory(ShopDbContext context)
    {
        Console.WriteLine("enter id category: ");
        int iddel = int.Parse(Console.ReadLine());
        var category = new Category
        {
            Id = iddel,
        };
        context.Remove(category);
        context.SaveChanges();
        Console.WriteLine("Category deleted");
    }
}