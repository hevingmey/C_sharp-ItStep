using System;

namespace AnimalWorld
{
    class Antelope : Herbivore
    {
        public Antelope(int weight) : base(weight) { }

        public override void EatGrass()
        {
            if (!Life) return;

            Weight += 10;
            Console.WriteLine("Antelope eats grass. Weight = " + Weight);
        }
    }
}