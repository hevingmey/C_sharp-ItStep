using Shop.App.Enums;
using Shop.App.Services;

namespace Shop.App.Managers;

public class ShopManager
{
    private readonly ProductService _productService;

    public ShopManager(ProductService productService)
    {
        _productService = productService;
    }

    public void Start()
    {
        bool work = true;

        while (work)
        {
            Console.WriteLine("1 - Show products");
            Console.WriteLine("0 - Exit");
            
                int choice=int.Parse(Console.ReadLine());
           

            switch ((Menu)choice)
            {
                case Menu.ShowProducts:
                    ShowProducts();
                    break;

                case Menu.Exit:
                    work = false;
                    break;
            }
        }
    }

    private void ShowProducts()
    {
        var products = _productService.GetAllProducts();

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Id} | {product.Name} | {product.Price}");
        }
    }
}