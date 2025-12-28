namespace Lesson_9;
// public delegate void ButtonHandler();
//
// internal class MyButton
// {
//     public event ButtonHandler evClick;
//
//     public void OnClick()
//     {
//         evClick?.Invoke();
//     }
// }
class CreditCard
{
    public int pin;
    public string Number { get; set; }
    public string Name { get; set; }
    public DateTime Expiration { get; set; }
    public int Limit { get; set; }
    public int Balance { get; set; }

    public event Action OnDeposit;
    public event Action OnWithdraw;
    public event Action OnCreditUse;
    public event Action OnWrongPin;
    public event Action OnExpired;
    public event Action OnNoMoney;

    public CreditCard(int pin, string number, string name, DateTime exp, int limit, int balance)
    {
        this.pin = pin;
        Number = number;
        Name = name;
        Expiration = exp;
        Limit = limit;
        Balance = balance;
    }

    bool CheckPin(int p)
    {
        if (p != pin)
        {
            OnWrongPin?.Invoke();
            return false;
        }
        return true;
    }

    bool CheckExp()
    {
        if (DateTime.Now > Expiration)
        {
            OnExpired?.Invoke();
            return false;
        }
        return true;
    }

    public void Deposit(int amount)
    {
        Balance += amount;
        OnDeposit?.Invoke();
    }

    public void Withdraw(int amount, int p)
    {
        if (!CheckExp()) return;
        if (!CheckPin(p)) return;

        if (Balance + Limit < amount)
        {
            OnNoMoney?.Invoke();
            return;
        }

        int before = Balance;
        Balance -= amount;
        OnWithdraw?.Invoke();

        if (before >= 0 && Balance < 0)
        {
            OnCreditUse?.Invoke();
        }
    }
}


class Program
{
    
    static void Main(string[] args)
    {
        CreditCard card = new CreditCard(
            1234,
            "1111 2222 3333 4444",
            "Ivan Ivanov",
            new DateTime(2027, 12, 31),
            500,
            100
        );

        card.OnDeposit += () => Console.WriteLine("поповнення");
        card.OnWithdraw += () => Console.WriteLine("списання");
        card.OnCreditUse += () => Console.WriteLine("кредитні гроші");
        card.OnWrongPin += () => Console.WriteLine("неправильний pin");
        card.OnExpired += () => Console.WriteLine("еарта прострочена");
        card.OnNoMoney += () => Console.WriteLine("недостатньо грошей");

        card.Deposit(200);
        card.Withdraw(300, 1234);
        card.Withdraw(600, 1234);
        card.Withdraw(10, 9999);

      
    }
}

        // MyButton button = new MyButton();
        // button.evClick+=()=>Console.WriteLine("Press button 1");
        // button.evClick+=()=>Console.WriteLine("Press button 2");
        // button.evClick+=()=>Console.WriteLine("Press button 3");
        // button.OnClick();
    
