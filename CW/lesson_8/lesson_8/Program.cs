namespace lesson_8;

abstract class Card
{
    public decimal Balance { get; set; }
    public decimal Commission;
    public Card (decimal balance, decimal commission)
    {
        Balance = balance;
        Commission = commission;
    }
    public abstract void BalanceWriteOff(decimal amount);
}

class Monobank : Card
{
    public Monobank(decimal balance)
        : base(balance, 2.0m){}

    public override void BalanceWriteOff(decimal amount)
    {
        decimal money = amount+Commission;
        Console.WriteLine($"Complete Monobank with {money} $");
    }
}

class Privatbank : Card
{
    public Privatbank(decimal balance)
        : base(balance, 20.0m){}

    public override void BalanceWriteOff(decimal amount)
    {
        decimal money = amount+Commission;
        Console.WriteLine($"Complete Privatebank with {money} $");
    }
}

class Abank : Card
{
    public Abank(decimal balance)
        : base(balance, 10.0m){}

    public override void BalanceWriteOff(decimal amount)
    {
        decimal money = amount+Commission;
        Console.WriteLine($"Complete Abank with {money} $");
    }
}

class ATM
{
    public void BalanceWriteOff(Card card, decimal amount)
    {
        Console.WriteLine("Started ATM");
        card.BalanceWriteOff(amount);
    }
}


class Program
{
    static void Main(string[] args)
    {
        ATM atm = new ATM();
        Card mono=new Monobank(1000m);
        Card abank=new Abank(500m);
        Card privat=new Privatbank(800m);
            
        atm.BalanceWriteOff(mono,250m);
        atm.BalanceWriteOff(abank,450m);
        atm.BalanceWriteOff(privat,50m);
    }
}







// public interface IOn
// {
//     void on();
// }
//
// public interface IOff
// {
//     void off();
// }
//
// public interface ICopy
// {
//     void copy();
// }
//
// public interface IPrint
// {
//     void print();
// }
//
// public interface IScan
// {
//     void scan();
// }
//
// public class Scanner : IOn, IOff, IScan
// {
//     public void on()
//     {
//         Console.WriteLine("working");
//     }
//
//     public void off()
//     {
//         Console.WriteLine("off");
//     }
//
//     public void scan()
//     {
//         Console.WriteLine("scan");
//     }
// }
//
// public class Printer : IOn, IOff, IPrint
// {
//     public void on()
//     {
//         Console.WriteLine("working");
//     }
//     
//     public void off()
//     {
//         Console.WriteLine("off");
//     }
//
//     public void print()
//     {
//         Console.WriteLine("print");
//     }
//
// }
//
// public class Copier:IOn,IOff,ICopy
// {
//     public void on()
//     {
//         Console.WriteLine("working");
//     }
//
//     public void off()
//     {
//         Console.WriteLine("off");
//     }
//
//     public void copy()
//     {
//         Console.WriteLine("copy");
//     }
// }
// public class MultiDevice:IOn,IOff,ICopy,IScan,IPrint
// {
//     public void on()
//     {
//         Console.WriteLine("working");
//     }
//
//     public void off()
//     {
//         Console.WriteLine("off");
//     }
//
//     public void copy()
//     {
//         Console.WriteLine("copy");
//     }
//
//     public void scan()
//     {
//         Console.WriteLine("scan");
//     }
//
//     public void print()
//     {
//         Console.WriteLine("print");
//     }
// }
    




