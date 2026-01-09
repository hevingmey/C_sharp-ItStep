namespace Lesson_11;
using Lesson_11.NewDirectory1;



// class Pair<T1, T2>
// {
//     public T1 First;
//     public T2 Second;
//
//     public void Add(T1 t1, T2 t2)
//     {
//         First = t1;
//         Second = t2;
//     }
//
//     public void Display()
//     {
//         Console.WriteLine($"First is {First}");
//         Console.WriteLine($"Second is {Second}");
//     }
// }
// class Box<T>
// {
//     public T value;
//     public Box(T content) 
//     {
//         this.value = content;
//     }
//     public T GetValue()
//     {
//         return value;
//     }
//     public void Print()
//     {
//         Console.WriteLine(value);
//     }
// }
// class Calculator<T> where T : struct
// {
//     public T Add(T a, T b)
//     {
//         dynamic w1 = a;
//         dynamic w2 = b;
//         return w1 + w2;
//     }
//     
// }
internal class Program
{
   
    static void Main(string[] args)
    {
        Shop shop = new Shop("ATB");

        shop.AddProduct(new Product("apple", 1.20m));
        shop.AddProduct(new Product("milk", 3.99m));
        shop.AddProduct(new Product("cheese", 3.32m));

        foreach (Product p in shop)
        {
            Console.WriteLine(p.Id);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            Console.WriteLine("----------------------");
        }        
        // Calculator<int> c = new Calculator<int>();
        // Console.WriteLine(c.Add(1, 2));
        // Pair<string,int>p1=new Pair<string, int>();
        // p1.Add("bread", 30);
        // p1.Display();

        // List<string> names = new List<string>();
        // names.Add("Bob");
        // names.Add("Alice");
        // names.Add("John");
        // Stack<string> stack = new Stack<string>();
        // LinkedList<string> list = new LinkedList<string>();
        //
        // Box<int> box1 = new Box<int>(10);
        // Console.WriteLine(box1.GetValue());
        // Box<string> box2 = new Box<string>("Hi");
        // Console.WriteLine(box2.GetValue());

        //Hashtable ht = new Hashtable();
        //ht["Alice"] = 20;

        //ArrayList list = new ArrayList();
        //list.Add(10);
        //list.Add(true);
        //list.Add("Hi");
        //Console.WriteLine(list[2]);
        //Console.WriteLine((int)list[0]*2);

        //Box box1 = new Box(1); //int
        //Box box2 = new Box(4.5); //double
        //Box box3 = new Box("Hello"); //string
        //Box box4 = new Box(box1); //string

        //int x = (int)box1.value;
        //Console.WriteLine(x);

    }
    
}