using Shop.App.Data;
using Shop.Domain.Entitys;
using Shop.Domain.Enums;

namespace Shop.App.Repository;

public class OrderRepository
{
    private readonly ShopDbContext _context;

    public OrderRepository(ShopDbContext context)
    {
        _context = context;
    }

    public void CreateOrder(int userId, List<(int productId, int quantity)> products)
    {
        using var transaction = _context.Database.BeginTransaction();

        try
        {
            decimal totalAmount = 0;

            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.Now,
                Status = StatusRole.paid
            };

            _context.Order.Add(order);
            _context.SaveChanges();

            foreach (var item in products)
            {
                var product = _context.Product.Find(item.productId);

                if (product == null)
                {
                    throw new Exception($"Product with id {item.productId} not found");
                }

                if (product.Store < item.quantity)
                {
                    throw new Exception($"Not enough product in store. Product id: {item.productId}");
                }

                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    ProductId = product.Id,
                    Quantity = item.quantity,
                    Price = product.Price
                };

                product.Store -= item.quantity;

                totalAmount += product.Price * item.quantity;

                _context.OrderItems.Add(orderItem);
            }

            order.TotalAmount = totalAmount;

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