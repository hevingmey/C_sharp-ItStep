namespace HW_17_12_25;

// class Product
// {
//     private string name;
//     private int price;
//     private int quantity;
//
//     public int Price
//     {
//         get => price;
//         set
//         {
//             if (value < 0)
//                 throw new ArgumentException("Price cannot be negative");
//             else
//             {
//                 price = value;
//             }
//         }
//     }
//
//     public int Quantity
//     {
//         get => quantity;
//         set
//         {
//             if (value < 0)
//                 throw new ArgumentException("Quantity cannot be negative");
//             else
//             {
//                 quantity = value;
//             }
//         }
//     }
//     public Product(string name, int price, int quantity)
//         {
//         this.name = name;
//         this.price = price;
//         this.quantity = quantity;
//         }
//
//
//     public void Input()
//     {
//         Console.Write("Please enter a name: ");
//         this.name = Console.ReadLine();
//         Console.Write("Please enter a price: ");
//         this.price = int.Parse(Console.ReadLine());
//         Console.Write("Please enter a quantity: ");
//         this.quantity = int.Parse(Console.ReadLine());
//
//         
//     }
//
//     public static Product operator +(Product p1, int value)
//     {
//
//         return new Product(p1.name,p1.quantity+value,p1.price);
//     }
//
//     public static Product operator -(Product p1, int value)
//     {
//         return new Product(p1.name, p1.quantity - value, p1.price);
//     }
//
//     public static bool operator !=(Product p1, Product p2)
//     {
//         return !(p1 == p2);
//     }
//
//     public static bool operator ==(Product p1, Product p2)
//     {
//         return p1.name == p2.name &&
//                p1.price == p2.price &&
//                p1.quantity == p2.quantity;
//     }
//
//     public static bool operator <(Product p1, Product p2)
//     {
//         return p1.quantity < p2.quantity;
//     }
//
//     public static bool operator >(Product p1, Product p2)
//     {
//         return p1.quantity > p2.quantity;
//     }
// }


class TemperatureArray
{
    private int[] temperature = new int [7];

    public int this[int index]
    {
        get { return temperature[index]; }
        set { temperature[index] = value; }
    }

    public void Input()
    {
        int counter = 1;
        
        for (int i = 0; i < temperature.Length; i++)
        {Console.WriteLine("day= : " + counter);
            temperature[i] = int.Parse(Console.ReadLine());
            
            counter++;

        }
    }

    public void Output()
    {
        int result1 = 0;
        int result = 0;
        for (int i = 0; i < temperature.Length; i++)
        {
            Console.Write(temperature[i] + " ");
        }

        for (int i = 0; i < temperature.Length; i++)
        {
             result += temperature[i]  ;
        }

        Console.WriteLine();
        result1 = result / 7;
        Console.WriteLine("average value= "+result1);
    }
}







class Program


{
    static void Main(string[] args)
    {
        TemperatureArray temperatureArray = new TemperatureArray();
        temperatureArray.Input();
        temperatureArray.Output();
        
    }
}