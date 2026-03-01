using Microsoft.EntityFrameworkCore;
using ONLShop.data;
using ONLShop.Entitys;
namespace ONLShop.metods;

public class Metod
{
  public  static void CreateCategory(ONLShopDbcontext context, string name)
    {
        var category = new Category{Name = name};
        context.Categories.Add(category);
        context.SaveChanges();
    }

  public  static void CreateProduct(ONLShopDbcontext context )
    {
        Console.WriteLine("name: ");
        string name=Console.ReadLine();
        Console.WriteLine("price: ");
        int price=int.Parse(Console.ReadLine());
        Console.WriteLine("description: ");
        string description=Console.ReadLine();
        Console.WriteLine("stock quantity: ");
        int stockQuantity=int.Parse(Console.ReadLine());
        Console.WriteLine("categoryID: ");
        int categoryId=int.Parse(Console.ReadLine());
        var product = new Product
        {
            Name = name,
            Price = price,
            Description = description,
            StockQuantity = stockQuantity,
            CategoryId = categoryId
        };
        
        context.Products.Add(product);
        context.SaveChanges();
    }

 public   static void changeNameProd(ONLShopDbcontext context)
    {
        Console.WriteLine("enter Id");
        int oldName=int.Parse(Console.ReadLine());
        Console.WriteLine("enter name: ");
        string newname=Console.ReadLine();
        var product = context.Products.Find(oldName);
        product.Name = newname;
        context.SaveChanges();
    }
    
 public   static void changeStokQuantity(ONLShopDbcontext context)
    {
        Console.WriteLine("enter Id");
        int oldName=int.Parse(Console.ReadLine());
        
        Console.WriteLine("enter Stok Quantity");
        int NewStokQuantity =int .Parse(Console.ReadLine());
        var product = context.Products.Find(oldName);
        product.StockQuantity = NewStokQuantity;
        context.SaveChanges();
        
    }
public static void deleteProduct(ONLShopDbcontext context)
    {
        Console.WriteLine("enter Id");
        int oldName=int.Parse(Console.ReadLine());
        var product = context.Products.Find(oldName);
        context.Products.Remove(product);
        context.SaveChanges();
    }

  public  static void showEmpty(ONLShopDbcontext context)
    {
        var products = context.Products
            .Where(p => p.StockQuantity == 0)
            .ToList();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id},{p.Name},{p.Price}");
        }
    }

  public  static void showProduct(ONLShopDbcontext context)
    {
        var product = context.Products
            .OrderByDescending(p => p.Price)
            .Take(3)
            .ToList();
        foreach (var p in product)
        {
            Console.WriteLine($"{p.Id},{p.Name},{p.Price},{p.StockQuantity},{p.Description}");
        }
    }

    public static void showProductsFromCateg(ONLShopDbcontext context)
    {
        Console.WriteLine("enter Id categ");
        int idcateg=int.Parse(Console.ReadLine());
        var products = context.Products
            .Where(p => p.CategoryId == idcateg)
            .OrderByDescending(p => p.Price)
            .ToList();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id},{p.Name},{p.Price}");
        }


    }

    public static void showCategFromProd(ONLShopDbcontext context)
    {
        Console.WriteLine("enter Id prod");
        int idprod=int.Parse(Console.ReadLine());
        var product = context.Products
            .Include(p => p.Category)
            .FirstOrDefault(p => p.Id == idprod);
        Console.WriteLine($"{product.Category.Name},{product.Id}");
    }
}