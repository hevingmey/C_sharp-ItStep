namespace Lesson_5;
using Lesson_5.NewDirectory1;
using MyMathLibrary;
class Atm
{
    private decimal balance;
    public Atm(decimal balance)
    {
        this.balance = balance;
    }

    public void deposit()
    {
        Console.WriteLine("enter deposit");
        decimal amount=decimal.Parse(Console.ReadLine());
        if (amount <= 0)
            throw new InvalidAmountException("Сума повинна бути більшою за 0");
        balance += amount;
        Console.WriteLine("complete");
    }

    public void withdraw()
    {
        Console.WriteLine("enter withdraw");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (amount <= 0)
            throw new InvalidAmountException("Сума повинна бути більшою за 0");

        else if (amount > balance)
            throw new NotEnoughMoneyInATMException("У банкоматі недостатньо грошей");

        balance -= amount;
        Console.WriteLine("complete");

    }

    public decimal CheckBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Atm atm = new Atm(500);
        Console.WriteLine(" menu");
        Console.WriteLine("1.Deposit");
        Console.WriteLine("2.withdraw");
        Console.WriteLine("3.checkBalance");
        Console.WriteLine("4.Exit");
        int value = Convert.ToInt32(Console.ReadLine());
        switch (value)
        {
            case 1:
                atm.deposit();
                break;
            case 2:
                atm.withdraw();
                break;
            case 3:
                atm.CheckBalance();
                break;
            case 4:
                Environment.Exit(0);
                break;
        }
       
        // int a, b;
        //
        // if(int.TryParse(Console.ReadLine(), out a))
        // {
        //     if(int.TryParse(Console.ReadLine(),out b))
        //     {
        //         try
        //         {
        //             Console.WriteLine(MyDivide(a, b));
        //         }
        //         catch(DivideByZeroException ex)
        //         {
        //             Console.WriteLine(ex.Message);
        //         }
        //     }
        // }
        // static int MyDivide(int a, int b)
        // {
        //     return a / b;
        // }
    }
}