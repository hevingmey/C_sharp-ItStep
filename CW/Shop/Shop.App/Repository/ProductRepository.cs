using Microsoft.EntityFrameworkCore;
using Shop.App.Data;
using Shop.Domain.Entitys;

namespace Shop.App.Repositories;

public class ProductRepository
{
    private readonly ShopDbContext _context;

    public ProductRepository(ShopDbContext context)
    {
        _context = context;
    }
    
    public void AddRange(List<Product> products)
    {
        _context.Product.AddRange(products);
        _context.SaveChanges();
    }

    public Product FindName(string name)
    {
        return _context.Product
            .AsNoTracking()
            .FirstOrDefault(x => x.Name == name);
    }

    public List<Product> GetAllProducts()
    {
        return _context.Product
            .AsNoTracking()
            .ToList();
    }
}