using System;
using  HW_08_12_2025.myclass;


// class Magazine
// {
//     private string name;
//     private int year;
//     private string description;
//     private int phoneNumber;
//     private string email;
//
//     public Magazine(string name, int year, string description, int phoneNumber, string email)
//     {
//         this.name = name;
//         this.year = year;
//         this.description = description;
//         this.phoneNumber = phoneNumber;
//         this.email = email;
//     }
//
//     public Magazine()
//     {
//         name = "Magazine";
//         year = 2025;
//         description = "Magazine description";
//         phoneNumber = 0;
//         email = "";
//     }
//
//
//     public string getName()
//     {
//         return name;
//     }
//
//     public void setName(string name)
//     {
//         this.name = name;    }
//
//
//
//     public int getYear()
//     {
//         return year;
//     }
//
//     public void setYear(int year)
//     {
//         this.year = year;
//     }
//
//     public string getDescription()
//   {
//       return description;
//   }
//
//   public void setDescription(string description)
//   {
//       this.description = description;
//   }
//
//   public int getPhoneNumber()
//   {
//       return phoneNumber;
//   }
//
//   public void setPhoneNumber(int phoneNumber)
//   {
//       if (phoneNumber<0)
//           Console.WriteLine("phone number cannot be negative");
//       this.phoneNumber = phoneNumber;
//   }
//
//   public string getEmail()
//   {
//       return email;
//   }
//
//   public void setEmail(string email)
//   {
//       this.email = email;
//   }
//   public void Input()
//   {
//       Console.WriteLine("Please enter name magazine:");
//       setName(Console.ReadLine());
//       
//       Console.WriteLine("Please enter year magazine:");
//       setYear(int.Parse(Console.ReadLine()));
//       
//       Console.WriteLine("Please enter description magazine:");
//       setDescription(Console.ReadLine());
//       
//       Console.WriteLine("Please enter phone number magazine:");
//       setPhoneNumber(int.Parse(Console.ReadLine()));
//       
//       Console.WriteLine("Please enter email magazine:");
//       setEmail(Console.ReadLine());
//       
//       Console.WriteLine();
//       
//       
//       
//   }
//
//   public void print()
//   {
//       Console.WriteLine($"name: {getName()}");
//       Console.WriteLine($"year: {getYear()}");
//       Console.WriteLine($"description: {getDescription()}");
//       Console.WriteLine($"phoneNumber: {getPhoneNumber()}");
//       Console.WriteLine($"email: {getEmail()}");
//   }
//  
// }



class Program
{
    static void Main(string[] args)
    {
        // Magazine magazine = new Magazine();
        // magazine.Input();
        // magazine.print();
        Shop shop = new Shop();
        shop.Input();
        shop.Output();
        



    }
}