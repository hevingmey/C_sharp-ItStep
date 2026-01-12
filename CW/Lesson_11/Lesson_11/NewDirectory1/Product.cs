using System;

namespace Lesson_11.NewDirectory1;

public   class Product: IComparable<Product>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
    }
    public override string ToString()
    {
        return $"Product - {Name}";
    }

    public int CompareTo(Product? other)
    {
        if (other == null) return 1;
        return string .Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
    }

   
}