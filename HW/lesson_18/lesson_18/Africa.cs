namespace AnimalWorld
{
    class Africa : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Antelope(80);
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion(90);
        }
    }
}