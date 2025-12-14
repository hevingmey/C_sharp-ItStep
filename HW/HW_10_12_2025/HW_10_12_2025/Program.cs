namespace HW_10_12_2025;
using  HW_10_12_2025.calculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter number");
        int n = int.Parse(Console.ReadLine());
        Calculator p1 = new Calculator(n);
        p1.change();
        p1.print();


    }
}