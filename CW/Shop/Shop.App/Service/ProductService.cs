using Shop.Domain.Entitys;
using Shop.App.Repositories;

namespace Shop.App.Services;

public class ProductService
{
    private readonly ProductRepository _repository;

    public ProductService(ProductRepository repository)
    {
        _repository = repository;
    }

    public List<Product> GetAllProducts()
    {
        return _repository.GetAllProducts();
    }
}