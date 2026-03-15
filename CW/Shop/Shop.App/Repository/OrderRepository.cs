using Microsoft.EntityFrameworkCore;
using Shop.App.Data;
using Shop.Domain.Entitys;

namespace Shop.App.Repositories;

public class OrderRepository
{
    private readonly ShopDbContext _context;

    public OrderRepository(ShopDbContext context)
    {
        _context = context;
    }

    public void CreateOrder(int userId, Dictionary<int, int> products)
    {
        using var transaction = _context.Database.BeginTransaction();

        try
        {
            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.Now
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            foreach (var item in products)
            {
                int productId = item.Key;
                int quantity = item.Value;

                var product = _context.Products.Find(productId);

                if (product == null || product.Store < quantity)
                {
                    throw new Exception("Not enough product in store");
                }

                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    ProductId = productId,
                    Quantity = quantity
                };

                product.Store -= quantity;

                _context.OrderItems.Add(orderItem);
            }

            _context.SaveChanges();

            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }
}