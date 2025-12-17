namespace HW_10_12_2025;
using  HW_10_12_2025.calculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculate");
        Console.WriteLine("chose number "); 
        Console.WriteLine("1.decimal to binary");
        Console.WriteLine("2.binary to decimal");
      
        int choice = int.Parse(Console.ReadLine());
        Calculator test = new Calculator();
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter decimal :");
                string dec=Console.ReadLine();
                string decResult=test.db(dec);
                Console.WriteLine(decResult);
                        break;
            case 2:
                Console.WriteLine("Enter binary :");
                string bin=Console.ReadLine();
                int binResult = test.bd(bin);
                Console.WriteLine(binResult);
                break;
        }
        


    }
}