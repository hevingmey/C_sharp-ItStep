namespace HW_12_12_2025.Employee1;

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
            
                throw new ArgumentException("Salary cannot be negative");
                
                salary = value;
            
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
//перевантаження 
    public static Employee operator +(Employee e, int value1)
    {
        return new Employee(e.Name , e.Age, e.Salary + value1);
    }
    public static Employee operator -(Employee e1, int value1)
    {
        return new Employee(e1.Name , e1.Age, e1.Salary - value1);
    }
    public static bool operator==(Employee e, Employee e2)
    {
        return e.Salary == e2.Salary;
    }

    public static bool operator !=(Employee e, Employee e2)
    {
        return !(e == e2);
    }

    public static bool operator >(Employee e, Employee e2)
    {
        return e.Salary > e2.Salary;
    }
    
    public static bool operator <(Employee e, Employee e2)
    {
        return e.Salary < e2.Salary;
    }
    public string Name
    {
        get{return name;}
        set{name = value;}
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: {Salary}");
    }

}