namespace HW_08_12_2025.myclass;

public class Shop
{
    private string shopname;
    private string shopadres;
    private string shopdescription;
    private int shopnumber;
    private string shopemail;

    public Shop(string shopname, string shopadress, string shopdescription, int shopnumber, string shopemail)
    {
        this.shopname = shopname;
        this.shopadres= shopadress;
        this.shopdescription = shopdescription;
        this.shopnumber = shopnumber;
        this.shopemail = shopemail;
    }

    public Shop()
    {
        shopname = "";
        shopadres = "";
        shopdescription = "";
        shopnumber = 0;
        shopemail = "";
    }

    public string Getname
    {
        get { return shopname; }
    }

    public void Setname(string shopname)
    {
        this.shopname = shopname;
    }
    public string Getadres
    {
        get { return shopadres; }
    }

    public void Setadres(string shopadres)
    {
        this.shopadres = shopadres;
    }

    public string Getdescription
    {
        get { return shopdescription; }
    }

    public void Setdescription(string shopdescription)
    {
        this.shopdescription = shopdescription;
    }
    public int Getnumber
    {
        get { return shopnumber; }
    }

    public void Setnumber(int shopnumber)
    {
 
        this.shopnumber = shopnumber;
    }

    public void Input()
    {
        Console.WriteLine("Enter shop name:");
        shopname = Console.ReadLine();
        
        Console.WriteLine("Enter shopadres:");
        shopadres = Console.ReadLine();
        
        Console.WriteLine("Enter description:");
        shopdescription = Console.ReadLine();
        
        Console.WriteLine("Enter shopnumber:");
        shopnumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter shopemail:");
        shopemail = Console.ReadLine();
    }

    public void Output()
    {
        Console.WriteLine("shop name: " + shopname);
        Console.WriteLine("shopadres: " + shopadres);
        Console.WriteLine("shopdescription: " + shopdescription);
        Console.WriteLine("shopnumber: " + shopnumber);
        Console.WriteLine("shopemail: " + shopemail);
    }
}