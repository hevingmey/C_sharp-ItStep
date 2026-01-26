using System.Text.RegularExpressions;

namespace Lesson_16;

class Developer
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }
    public Developer(string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        Developer d1 = new Developer("Alex", 1500, "midlle");
        Developer d2 = new Developer("John", 1600, "midlle");
        Developer d3 = new Developer("Jane", 2000, "senior");
        Developer d4 = new Developer("Julia", 1900, "senior");
        Developer d5 = new Developer("Reaigan", 1300, "junior");
        List<Developer>people =new List<Developer>(){d1, d2, d3, d4, d5};
            // групування обʼєктів по заданому параметру 
        // var peopleGroup = from person in people
        //     group person by person.Position;
        // foreach (IGrouping<string, Developer> g in peopleGroup)
        // {
        //     Console.WriteLine(g.Key);
        //     foreach (var w in g)
        //         Console.WriteLine(w.Name);
        // }

        //Console.WriteLine('\n');
            // групування для знаходження сумми зарплати для кожної групи 
            
        var people2= from person in people
            group person by person.Position into g
                select new { Name=  g.Key, Salary = g.Sum(s => s.Salary) };
        foreach (var item in people2)
            Console.WriteLine(item.Name+" "+item.Salary);
        Console.WriteLine('\n');
        
    }
}