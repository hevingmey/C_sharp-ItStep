namespace AnimalWorld
{
    class America : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison(100);
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf(95);
        }
    }
}