using System.Collections;
using System.Collections.Generic;

namespace Lesson_11.NewDirectory1;

public class Shop : IEnumerable<Product>
{
    public string Name { get; set; }

    private List<Product> products = new List<Product>();

    public Shop(string name)
    {
        Name = name;
    }

    

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        return products.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Sorting()
    {
        products.Sort(); 
    }
}

