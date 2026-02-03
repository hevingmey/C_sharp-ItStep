using System;

namespace AnimalWorld
{
    class Bison : Herbivore
    {
        public Bison(int weight) : base(weight) { }

        public override void EatGrass()
        {
            if (!Life) return;

            Weight += 10;
            Console.WriteLine("Bison eats grass. Weight = " + Weight);
        }
    }
}