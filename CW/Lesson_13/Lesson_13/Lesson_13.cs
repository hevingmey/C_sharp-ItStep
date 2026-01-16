// using Newtonsoft.Json;
//
// namespace Lesson_13;
//
// public class PersonsCmS
// {
//     public string PathToFile(get;private HashSet ;>
//
//     public void addPersonToFile(Person person)
//     {
//
//     }
//
// };
//
//
// public class Person
// {
//     public string Name { get; set; }
//     public short Age { get; set; }
//     public Person()
//     {
//         Name = "default";
//         Age = 0;
//     }
//     public Person(string name, short age)
//     {
//         Name = name;
//         Age = age;
//     }
//
//     public override string ToString()
//     {
//         return $"Name: {Name}, Age: {Age}";
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Person[] people =
//         // {
//         //     new Person("John Doe", 25),
//         //     new Person("John Doe", 26),
//         //     new Person("John Doe", 27),
//         // };
//         // string json1 = JsonConvert.SerializeObject(people);
//         // File.WriteAllText("people.json", json1);
//         
//         Person persone = new Person()
//         {
//             Name = "John Doe",
//             Age = 20
//         };
//         string json = JsonConvert.SerializeObject(persone);
//         File.WriteAllText("person.json", json);
//     }
// }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace FileSystem;
//
// internal class Person
// {
//     public static int Id { get; private set; }
//     public string Name { get; set; }
//     public short Age { get; set; }
//     static Person()
//     {
//         Id = 0;
//     }
//     public Person()
//     {
//         Name = "default";
//         Age = 0;
//         ++Id;
//     }
//     public Person(string name, short age)
//     {
//         Name = name;
//         Age = age;
//         ++Id;
//     }
//     public override string ToString()
//     {
//         return $"Id: {Id} | Name: {Name}. Age: {Age}";
//     }
// }
using System;
using System.IO;
using Newtonsoft.Json;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "people.json";
            PersonsCMS cms = new PersonsCMS(path);

            
            cms.addPersonToFile(new Person("Q", 21));
            cms.addPersonToFile(new Person("Alex", 22));
            cms.addPersonToFile(new Person("Alan", 37));

            Console.WriteLine(" after adding ");
            cms.showAllPersons();


            bool removed1 = cms.removePersonToFile(1);
            Console.WriteLine("removed id 1: " + removed1);

            Console.WriteLine("after removing id 1 ");
            cms.showAllPersons();
            
        }
    }
}
