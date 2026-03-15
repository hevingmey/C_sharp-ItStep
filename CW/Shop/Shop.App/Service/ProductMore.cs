using Shop.App.Repositories;
using Shop.App.Repository;
using Shop.Domain.Entitys;

namespace Shop.App.Service;

public class ProductSeeder
{
    private readonly ProductRepository _repository;

    public ProductSeeder(ProductRepository repository)
    {
        _repository = repository;
    }

    public void MoresProducts(int count)
    {
        var products = new List<Product>();

        for (int i = 1; i <= count; i++)
        {
            products.Add(new Product
            {
                Name = $"Product_{i}",
                Price = Random.Shared.Next(10, 5000),
                CreatedAt = DateTime.Now
            });
        }

        _repository.AddRange(products);
    }
}