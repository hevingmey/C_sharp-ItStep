using Shop.App.Data;
using Shop.Domain.Entitys;
using Shop.Domain.Enums;
using Shop.App.Repository;

namespace Shop.App.Service;

public class service
{
    public class OrderService
    {
        private readonly OrderRepository _repository;

        public OrderService(OrderRepository repository)
        {
            _repository = repository;
        }

        public void CreateOrder()
        {
            Console.WriteLine("Enter user id:");
            int userId = int.Parse(Console.ReadLine()!);

            var products = new List<(int productId, int quantity)>();

            while (true)
            {
                Console.WriteLine("Enter product id:");
                int productId = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter quantity:");
                int quantity = int.Parse(Console.ReadLine()!);

                products.Add((productId, quantity));

                Console.WriteLine("Add another product? (yes/no)");
                string answer = Console.ReadLine()!.ToLower();

                if (answer != "yes")
                {
                    break;
                }
            }

            try
            {
                _repository.CreateOrder(userId, products);
                Console.WriteLine("Order created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
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
    