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
public class Magazine
{
    private string name;
    private int year;
    private string description;
    private int phoneNumber;
    private string email;

    public Magazine(string name, int year, string description, int phoneNumber, string email)
    {
        this.name = name;
        this.year = year;
        this.description = description;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public Magazine()
    {
        name = "Magazine";
        year = 2025;
        description = "Magazine description";
        phoneNumber = 0;
        email = "";
    }


    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;    }



    public int getYear()
    {
        return year;
    }

    public void setYear(int year)
    {
        this.year = year;
    }

    public string getDescription()
  {
      return description;
  }

  public void setDescription(string description)
  {
      this.description = description;
  }

  public int getPhoneNumber()
  {
      return phoneNumber;
  }

  public void setPhoneNumber(int phoneNumber)
  {
      if (phoneNumber<0)
          Console.WriteLine("phone number cannot be negative");
      this.phoneNumber = phoneNumber;
  }

  public string getEmail()
  {
      return email;
  }

  public void setEmail(string email)
  {
      this.email = email;
  }
  public void Input()
  {
      Console.WriteLine("Please enter name magazine:");
      setName(Console.ReadLine());
      
      Console.WriteLine("Please enter year magazine:");
      setYear(int.Parse(Console.ReadLine()));
      
      Console.WriteLine("Please enter description magazine:");
      setDescription(Console.ReadLine());
      
      Console.WriteLine("Please enter phone number magazine:");
      setPhoneNumber(int.Parse(Console.ReadLine()));
      
      Console.WriteLine("Please enter email magazine:");
      setEmail(Console.ReadLine());
      
      Console.WriteLine();
      
      
      
  }

  public void print()
  {
      Console.WriteLine($"name: {getName()}");
      Console.WriteLine($"year: {getYear()}");
      Console.WriteLine($"description: {getDescription()}");
      Console.WriteLine($"phoneNumber: {getPhoneNumber()}");
      Console.WriteLine($"email: {getEmail()}");
  }
 
}