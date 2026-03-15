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

    public List<Product> GetAllProducts()
    {
        return _context.Product
            .AsNoTracking()
            .ToList();
    }
}