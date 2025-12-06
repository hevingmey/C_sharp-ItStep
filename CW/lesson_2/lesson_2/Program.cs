namespace Less3_array_string
{
    class Cat
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            rnd.Next(10,30);
            
            // Object obj1 = 5;
            // Object obj2 = "Hello";
            // Object obj3 = new Cat();
            // Console.WriteLine((int)obj1+6);
            // Console.WriteLine((string)obj2+(string)obj2);
            int[] arr = new int[3];
            Console.WriteLine(arr.Length);
            
        }
    }
}