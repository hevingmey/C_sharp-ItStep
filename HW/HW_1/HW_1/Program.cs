namespace HW_1;

class Program
{
    static void Main(string[] args)
    {          //first task
        // Console.WriteLine("enter number(:(1>100) ");
        // int x =Convert.ToInt32(Console.ReadLine());
        // if (x % 3 == 0)
        //     {
        //     Console.WriteLine("Fizz");
        //     }
        // else if (x % 5 == 0)
        //     {
        //     Console.WriteLine("Buzz");
        //     }
        // else if(x % 3 == 0  && x % 5 == 0)
        //     {
        //     Console.WriteLine("FizzBuzz");
        //     }
        //     else if (x>100)
        //         Console.WriteLine("error");
        
                //second task
        // Console.WriteLine("enter first number");
        // int x = int.Parse(Console.ReadLine());
        // Console.WriteLine("enter second number");
        // int y = int.Parse(Console.ReadLine());
        //
        // int result = x * y / 100;
        // Console.WriteLine(result);
        
                //fird   task
                // int x= Convert.ToInt32(Console.ReadLine());
                // int y = Convert.ToInt32(Console.ReadLine());
                // int z = Convert.ToInt32(Console.ReadLine());
                // int w = Convert.ToInt32(Console.ReadLine());
                //
                // int x1 = x * 1000;
                // int y1 = y * 100;
                // int z1 = z * 10;
                // int result = x1 + y1 + z1 + w;
                // Console.WriteLine(result);

                //sixth task
                Console.WriteLine("shoose degres ");
                Console.WriteLine("1  Celsius");
                Console.WriteLine("2  Fahrenheit");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter degrees ");
                int x =Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    double f = x * 1.8 + 32;
                    Console.WriteLine("Fahrenheit is " + f);
                }
                else if (choice == 2)
                {
                    double c=(x-32)/1.8;
                    Console.WriteLine("Celsius is " + c);
                }


    }
}