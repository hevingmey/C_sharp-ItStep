namespace Lesson_13;

internal class Person
{
    public static int Id { get; private set; }
    public string Name { get; set; }
    public short Age { get; set; }
    static Person()
    {
        Id = 0;
    }
    public Person()
    {
        Name = "default";
        Age = 0;
        ++Id;
    }
    public Person(string name, short age)
    {
        Name = name;
        Age = age;
        ++Id;
    }
    public override string ToString()
    {
        return $"Id: {Id} | Name: {Name}. Age: {Age}";
    }
}