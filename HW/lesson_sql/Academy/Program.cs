using Academy.Context;
using Academy.Entitys;

namespace Academy;

class Program
{
    static void Main(string[] args)
    {
        using (var Context=new AcademyDbContext())
        {
            // //Context.Database.EnsureCreated();
            // //context.Database.EnsureDeleted();
            // var user = new Student();
            // Console.WriteLine("enter name");
            // user.name = Console.ReadLine();
            // Console.WriteLine("enter surname");
            // user.surname =Console.ReadLine();
            // Context.Students.Add(user);
            // Context.SaveChanges();
            // var Student=Context.Students.FirstOrDefault(st=>st.id==1);
            // if (Student!=null)
            // {
            //     Student.name = "Bob";
            //     Context.SaveChanges();
            //     Console.WriteLine($"name : {Student.name} {Student.surname}");
            // }
            
        }
    }
}