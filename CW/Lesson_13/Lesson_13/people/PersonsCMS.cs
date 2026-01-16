using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lesson_13;


internal class PersonsCMS
{
   
    public string PathToFile { get; private set; }
    public PersonsCMS(string path)
    {
        PathToFile = path;
    }
    public void addPersonToFile(Person person)
    {
        Person[] people ;
        if (File.Exists(PathToFile))
        {
            string json=File.ReadAllText(PathToFile);
            people= string.IsNullOrWhiteSpace(json)
                ? new Person[0]
                : JsonConvert.DeserializeObject<Person[]>(json);
        }
        else
        {
            people = new Person[0];
        }
        Person [] newPeople = new Person[people.Length + 1];
        for (int i=0; i<people.Length; i++)
            newPeople[i] = people[i];
        newPeople[newPeople.Length-1] = person;
        string newJson =JsonConvert.SerializeObject(newPeople, Formatting.Indented);
        File.WriteAllText(PathToFile, newJson);
    }
    public void showAllPersons()
    {
        string json = File.ReadAllText(PathToFile);
        Person[] people = JsonConvert.DeserializeObject<Person[]>(json) ?? new Person[0];

        for (int i = 0; i < people.Length; i++)
            Console.WriteLine($"{i}: {people[i]}");
    }
    public bool removePersonToFile(int id)
    {
        if (!File.Exists(PathToFile))
            return false;

        string json = File.ReadAllText(PathToFile);
        Person[] people = JsonConvert.DeserializeObject<Person[]>(json);

        if (people == null)
            return false;

        if (id < 0 || id >= people.Length)
            return false;

        Person[] newPeople = new Person[people.Length - 1];

        int index = 0;
        for (int i = 0; i < people.Length; i++)
        {
            if (i != id)
            {
                newPeople[index] = people[i];
                index++;
            }
        }

        string newJson = JsonConvert.SerializeObject(newPeople);
        File.WriteAllText(PathToFile, newJson);

        return true;
        throw new NotImplementedException();
    }

}