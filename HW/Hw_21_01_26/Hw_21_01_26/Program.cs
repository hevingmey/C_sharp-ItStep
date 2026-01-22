using System.Globalization;
using System.Security.Cryptography;
using System.Linq;

namespace Hw_21_01_26;

class Phone
{
    public string Name { get; set; }
    public string Producer{ get; set; }
    public double Price { get; set; }
    public DateOnly ReleseDate { get; set; }

    public Phone( string name, string producer, double price, DateOnly  releseDate)
    {
        Name = name;
        Producer = producer;
        Price = price;
        ReleseDate = releseDate;
        
        
    }

    
    
      
      
        

    
}

class Program
{
    static void Main(string[] args)
    {
        Phone p1=  new Phone("s20", "samsung ", 100, new DateOnly(2022, 12, 11));
        Phone p2 =new Phone("p30","OPPO",75, new DateOnly(2019, 5, 13));
        Phone p3=new Phone("13 mini","Iphone",200, new DateOnly(2017, 7, 18));
        Phone p4=new Phone("17pro max","Iphone",698, new DateOnly(2025, 3, 28));
        Phone p5=new Phone("Xrw", "motorola",430, new DateOnly(2024, 2, 8));
        List<Phone>howmanyP=new List<Phone>(){p1,p2,p3,p4,p5};
        Console.WriteLine("How many phone do we have? ");
        int count=howmanyP.Count;
        Console.WriteLine(count);
        Console.WriteLine("price >100");
        int count1 = howmanyP.Count(x => x.Price > 100);
        Console.WriteLine(count1);
        Console.WriteLine(" 400> price <700");
        int count2 = howmanyP.Count(e => e.Price < 700 && e.Price > 400);
        Console.WriteLine(count2);
        Console.WriteLine("how many iphone do we have? ");
        int count3=howmanyP.Count(w => w.Producer == "Iphone");
        Console.WriteLine(count3);
        Console.WriteLine("max price:");
        double maxprice = howmanyP.Max(z=>z.Price);
        foreach (var c in howmanyP.Where(z=>z.Price == maxprice))
        {
            Console.WriteLine(c.Name);
        }

        Console.WriteLine("min price:");
        double minprice = howmanyP.Min(z=>z.Price);
        foreach (var c in howmanyP.Where(z => z.Price == minprice))
        {
            Console.WriteLine(c.Name);
        }

        Console.WriteLine("new phone :");
        DateOnly new_Phone=howmanyP.Max(z=>z.ReleseDate);
        foreach (var t in howmanyP.Where(z=>z.ReleseDate == new_Phone))
        {
            Console.WriteLine(t.Name);
        }

        Console.WriteLine("old phone :");
        DateOnly old_Phone=howmanyP.Min(z=>z.ReleseDate);
        foreach (var k in howmanyP.Where(z=>z.ReleseDate == old_Phone))
        {
            Console.WriteLine(k.Name);
        }

        Console.WriteLine("average price :");
        double average =howmanyP.Average(z=>z.Price);
        Console.WriteLine(average);

        
        
    }
}