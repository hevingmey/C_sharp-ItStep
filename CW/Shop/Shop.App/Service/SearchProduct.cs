using System.Diagnostics;
using Shop.App.Repositories;
using Shop.App.Repository;

namespace Shop.App.Service;

public class ProductSearchkService
{
    private readonly ProductRepository _repository;

    public ProductSearchkService(ProductRepository repository)
    {
        _repository = repository;
    }

    public void ISearchByName(string productName)
    {
        var stopwatch = Stopwatch.StartNew();

        var product = _repository.FindName(productName);

        stopwatch.Stop();

        if (product is null)
        {
            Console.WriteLine("продукт не знайдено");
        }
        else
        {
            Console.WriteLine($"знайдено: {product.Id} | {product.Name} | {product.Price}");
        }

        Console.WriteLine($"запит виконався за {stopwatch.ElapsedMilliseconds} ms");
    }
}