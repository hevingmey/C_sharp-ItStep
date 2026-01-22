using System;
using System.Globalization;
using System.Linq;
namespace Lesson_15;

class Developer
{
    public int counter;
    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }

    public List<string> Languages { get; set; } = new List<string>();
    public Developer(string name, int age, string country)
    {
        Name = name;
        Age = age;
        Country = country;
        
    }
}
class Program
{
    static void Main(string[] args)
    
        {
         Developer p1=   new Developer("John ", 34, "Ukraine");
          Developer p2=  new Developer("Alex ", 23, "USA");
        Developer p3=    new Developer("John ", 24, "UK");
        Developer p4 = new Developer(" Smith", 25, "France");
        p1.Languages.Add("C++");
        p2.Languages.Add("C#");
        p3.Languages.Add("Java");
        p4.Languages.Add("Python");
        List<Developer> Human = new List<Developer>() { p1, p2, p3, p4 };
        Console.WriteLine("who is from Ukraine and France?");
        var people =from i in Human
            
            where i.Country == "Ukraine" ||  i.Country == "France"
            select i;
        foreach (var i in people)
        {
            Console.WriteLine(i.Name);
        }

        var languages =
            from t in Human
            where t.Languages.Contains("C#") || t.Languages.Contains("Java")
            select t;
        Console.WriteLine("How knows C# and Java?");
        foreach (var t in languages)
        {
            Console.WriteLine(t.Name);
        }

        Console.WriteLine("who isn't know C++ and age>20");
        var human =
            from w in Human
            where w.Age > 20 && !w.Languages.Contains("C++") 
                  select w;
        foreach (var w in human)
        {
            Console.WriteLine(w.Name);
        }

        Console.WriteLine("from oldest to youngest");
        var oldest =Human.OrderByDescending(x => x.Age);
        foreach (var x in oldest)
        {
            Console.WriteLine(x.Name);
        }

        Console.WriteLine("how many are people know C#");
        int counter=human.Count(p=>p.Languages.Contains("C#"));
        Console.WriteLine(counter);
        }
   
}