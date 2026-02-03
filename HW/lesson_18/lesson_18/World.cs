namespace AnimalWorld
{
    class World
    {
        private Herbivore herbivore;
        private Carnivore carnivore;

        public World(Continent continent)
        {
            herbivore = continent.CreateHerbivore();
            carnivore = continent.CreateCarnivore();
        }

        public void FeedHerbivores()
        {
            herbivore.EatGrass();
        }

        public void FeedCarnivores()
        {
            carnivore.Eat(herbivore);
        }
    }
}