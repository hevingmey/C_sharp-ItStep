namespace AnimalWorld
{
    class Program
    {
        static void Main()
        {
            World world1 = new World(new Africa());
            world1.FeedHerbivores();
            world1.FeedCarnivores();

            World world2 = new World(new America());
            world2.FeedHerbivores();
            world2.FeedHerbivores();
            world2.FeedCarnivores();
        }
    }
}