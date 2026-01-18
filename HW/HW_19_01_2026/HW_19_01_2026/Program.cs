namespace HW_19_01_2026;

enum TypeStore
{
Grocery,
Household,
Clothes,
Shoes
};

class Shop:IDisposable
{
    public string Name { get; set; }
    private bool disposed=false;
    public string Adress{get;set;}
    public  TypeStore Type {get;set;}
      
    public Shop(string name, string adress, TypeStore  type)
    {
        Name = name;
        Adress = adress;
        Type = type;

    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}, {Adress}, {Type}");
    }

    public void Dispose()
    {
        if (!disposed)
        {
            Console.WriteLine("disposed complete");
            disposed = true;
        }
    }
            //3
    ~Shop()
    {
        Console.WriteLine("shop destroyed");
    }
}

                  
                        // 1
// class Play: IDisposable
// {
//     public string Title{get; set;}
//     public string Author{get; set;}
//     public string Year{get; set;}
      //  private bool disposed = false;
//
//     public Play(string title, string author, string year)
//     {
//         Title = title;
//         Author = author;
//         Year = year;
//     }
//
//     public void showInfo()
//     {
//         Console.WriteLine($"{Title} - {Author} - {Year}");
//     }
//     ~Play()
//     {
//         Console.WriteLine("destroed ");
//     }
                //3
        // public void Dispose()
        // {
        //     if (!disposed)
        //     {
        //         Console.WriteLine("disposed complete");
        //         disposed = true;
        //     }
        // }
//     
// }
class Program
{
    static void Main(string[] args)
    {
                //1
    //     static void Test()
    //     {
    //        Play p=new Play("James", "John", "2021");
    //                p.showInfo(); 
    //     }
    //     Test();
    //     GC.Collect();
    //     GC.WaitForPendingFinalizers();
    // 
                    //2

                    Shop s = new Shop("ATB", "Kharkiv", TypeStore.Household);
                    
                        s.ShowInfo();
                        s.Dispose();
     }
}