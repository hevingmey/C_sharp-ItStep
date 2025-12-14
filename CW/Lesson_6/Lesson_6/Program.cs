using System.Security.Cryptography;
using Lesson_6.Student;

namespace Lesson_6;

internal class Point 
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
         
    }
}

class Program
{
    static void Main(string[] args)
    {
        //     Employee first = new Employee("Petro", 35, 2500);
        //     first.Name = "Ivan";
        //     first.Age = 30;
        //     first.Salary = 500;
        //   first.Print();
        // }
        // internal class Point
        // {
        //     public int X {  get; set; }
        //     public int Y { get; set; }
        //     public Point(int x, int y)
        //     {
        //         X = x;
        //         Y = y;
        //     }
        //     public override string ToString()
        //     {
        //         return $"X: {X} Y: {Y}";
        //     }
        //     public static Point operator+(Point obj, int n)
        //     {
        //         Point p = new Point(obj.X+n, obj.Y+n);
        //         return p;
        //     }


        Point p1 = new Point(2, 4);
        Point p2 = new Point(4, 6);
        Point p3 = p1 + p2;
        Console.WriteLine(p3);
    }
}