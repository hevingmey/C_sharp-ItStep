namespace AnimalWorld
{
    abstract class Herbivore
    {
        public int Weight { get; protected set; }
        public bool Life { get; set; } = true;

        protected Herbivore(int weight)
        {
            Weight = weight;
        }

        public abstract void EatGrass();
    }
}