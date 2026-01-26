namespace Lesson_17;


class Unit
{
    private static int count = 0;
  

    public Guid ID { get; }
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Health { get; set; }

   
    private Unit(string name, int damage, int health)
    {
        ID = Guid.NewGuid();
        Name = name;
        Damage = damage;
        Health = health;
    }

   
    public static Unit Create(string name, int damage, int health)
    {
        if (count ==5)
        {
            Console.WriteLine("limits 5 units");
            return null;
        }

        count++;
        return new Unit(name, damage, health);
    }
}

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 8; i++)
        {
            Unit u = Unit.Create("Unit " + i, 10 * i, 100);

            if (u != null)
                Console.WriteLine($"created: {u.Name} | {u.ID}");
        }
    }
}