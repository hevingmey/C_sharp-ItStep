namespace cw_Ch_Spaine;
using cw_Ch_Spaine.Context;
using cw_Ch_Spaine.Entitys;
class Program
{
    static void Main(string[] args)
    {
        using (var Context = new ChampionDbContext())
        {
           // Context.Database.EnsureCreated();
            var user = new Player();
            //1
          //  enterPlayer(Context);
            //2
            showPlayer(Context);
            //3
            showPlayersfromBrazil(Context);
            
            // Context.Database.EnsureDeleted();

        }
    }

    static void enterPlayer(ChampionDbContext context)
    {
        var person = new Player();
        Console.WriteLine("enter a name");
        person.name = Console.ReadLine();
        Console.WriteLine("enter a surname");
        person.sername = Console.ReadLine();
        Console.WriteLine("enter a country");
        person.country = Console.ReadLine();
        Console.WriteLine("enter a position");
        person.position = Console.ReadLine();
        Console.WriteLine("enter a number");
        person.number = int.Parse(Console.ReadLine());
        
        context.Players.Add(person);
        context.SaveChanges();
        
        
    }

   static void showPlayer(ChampionDbContext context)
    {
        foreach (var p in context.Players)
            
        {
            Console.WriteLine($"{p.name} {p.sername} {p.country} {p.position} {p.number}");
        }
    }

    static void showPlayersfromBrazil(ChampionDbContext context)
    {
        foreach (var p in context.Players)
            if(p.country=="Brazil")
                Console.WriteLine($"{p.name} {p.sername} {p.country} {p.position} {p.number}");
    }
}