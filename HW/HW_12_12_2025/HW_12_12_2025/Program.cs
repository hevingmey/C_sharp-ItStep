namespace HW_12_12_2025;
using HW_12_12_2025.Employee1;
class Program
{
    static void Main(string[] args)
    {
          Employee first = new Employee("Ivan",31,3500);
          
        first.Print();
        Employee second = new Employee("Petro", 35, 2500);
        second.Print();
        Employee test=first+200;
        Employee test2=second-100;
        bool test3=first>second;
        bool test4=second>first;
        bool test5=second!=first;
        bool test6=first==second;
        
    }
}