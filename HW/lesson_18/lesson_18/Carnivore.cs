namespace AnimalWorld
{
    abstract class Carnivore
    {
        public int Power { get; protected set; }

        protected Carnivore(int power)
        {
            Power = power;
        }

        public abstract void Eat(Herbivore herbivore);
    }
}