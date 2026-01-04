namespace HW_24_12_25;

class Item
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public Item(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }
}

class Backpack
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Fabric { get; set; }
    public double Weight { get; set; }
    public double MaxVolume { get; set; }

    private List<Item> items = new List<Item>();

    public event Action<Item> ItemAdded;
    public event Action<Item> ItemRemoved;
    public event Action<Item> ItemChanged;

    public double CurrentVolume()
    {
        double sum = 0;
        foreach (var item in items)
            sum += item.Volume;
        return sum;
    }

    public void AddItem(Item item)
    {
        if (CurrentVolume() + item.Volume > MaxVolume)
            throw new Exception("Перевищено обсяг рюкзака");

        items.Add(item);
        ItemAdded?.Invoke(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        ItemRemoved?.Invoke(item);
    }

    public void ChangeItem(Item oldItem, Item newItem)
    {
        double newVolume =
            CurrentVolume() - oldItem.Volume + newItem.Volume;

        if (newVolume > MaxVolume)
            throw new Exception("Перевищено обсяг рюкзака");

        items.Remove(oldItem);
        items.Add(newItem);
        ItemChanged?.Invoke(newItem);
    }
}

class Program
{
    static void Main()
    {
        Backpack backpack = new Backpack
        {
            Color = "Black",
            Brand = "Nike",
            Fabric = "Polyester",
            Weight = 1.2,
            MaxVolume = 20
        };

        backpack.ItemAdded += delegate (Item item)
        {
            Console.WriteLine("Додано предмет: " + item.Name);
        };

        backpack.ItemRemoved += delegate (Item item)
        {
            Console.WriteLine("Видалено предмет: " + item.Name);
        };

        backpack.ItemChanged += delegate (Item item)
        {
            Console.WriteLine("Змінено предмет: " + item.Name);
        };

        Item book = new Item("Book", 5);
        Item bottle = new Item("Bottle", 3);

        try
        {
            backpack.AddItem(book);
            backpack.AddItem(bottle);

            Item bigBook = new Item("Big Book", 10);
            backpack.ChangeItem(book, bigBook);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}
