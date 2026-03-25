using System.Globalization;

namespace SystemPrograming;

class Bank
{
    private decimal Balance;
    private bool IsBlock;
    private object _lock = new object();

    public Bank(decimal balance, bool isBlock)
    {
        Balance = balance;
        IsBlock=isBlock;
    }


    public void Deposit(decimal amount)
    {
        lock (_lock)
        {
             if (IsBlock)
                    {
                        Console.WriteLine("your account is blocked");
                        return;
                    } 
             Balance += amount;
             Console.WriteLine($"thread {Thread.CurrentThread.ManagedThreadId} deposit {amount}");
            Console.WriteLine();
        }
       
    }

    public void Withdraw(decimal amount)
    {
        lock (_lock)
        {
             if(IsBlock)
                    {
                        Console.WriteLine("your account is blocked");
                        return;
                    }
                    
            
                    if (Balance < amount)
                    {
                        Console.WriteLine("you cannot withdraw more than your balance");
                        IsBlock = true;
                        Console.WriteLine("Blocked");
                    
                    }
                    
                    else
                    { Console.WriteLine($"thread {Thread.CurrentThread.ManagedThreadId} withdraw {amount}");
                        Balance -= amount;
                        Console.WriteLine(" ");
                    }
        }
       
    }
    public bool GetStatus()
    {
        lock (_lock)
        {
            return IsBlock;
        }
        
    }
}  



