using Lesson_4.Models;

namespace Lesson_4;
using Lesson_4.Models;

class Pasport
{
    private int number;
    private  string name;
    private  int age;
    public MyDate date; 
    public Pasport(int number, int age, MyDate date, string name)
    {
        this.date = date;
        this.number = number;
        this.age = age;
        this.name = name;
    }

    public override string ToString()
    {
        return $"{this.number}-{this.name}-{this.age}-{this.date.ToString()}";
    }


}
class Program
{
    static void Main(string[] args)
    {
        MyDate myDate = new MyDate(2000, 1, 5);
        Pasport pasp = new Pasport(12345, 26, myDate, "Ivan");
        Console.WriteLine(pasp);
    }
}