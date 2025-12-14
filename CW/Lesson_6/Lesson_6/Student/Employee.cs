namespace Lesson_6.Student;

public class Employee
{
    private string name;
    private int age;
    private int salary;
 public  Employee(string name, int age, int salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }
 public int Salary
 {
     get
     {
         return salary;
     }
     set
     {
         if (value < 0)
         {
             throw new ArgumentException("Salary cannot be negative");
             salary = value;
         }
     }
 }

 public int Age
 {
     get
     {
         return age;
     }
     
     set
     {
         if (value < 0 ||  value > 120)
             throw new ArgumentException("Age cannot be negative or  greater than 120 years");
         
         age = value;
     }
 }
 public string Name { get; set; }

 public void Print()
 {
     Console.WriteLine($"Name: {Name}");
     Console.WriteLine($"Age: {Age}");
     Console.WriteLine($"Salary: {Salary}");
 }

}

