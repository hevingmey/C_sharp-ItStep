using Shop.App.Repositories;

namespace Shop.App.Services;

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

        var products = new Dictionary<int, int>();

        while (true)
        {
            Console.WriteLine("Enter product id:");
            int productId = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter quantity:");
            int quantity = int.Parse(Console.ReadLine()!);

            products.Add(productId, quantity);

            Console.WriteLine("Add another product? (yes/no)");
            string answer = Console.ReadLine()!.ToLower();

            if (answer != "yes")
                break;
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