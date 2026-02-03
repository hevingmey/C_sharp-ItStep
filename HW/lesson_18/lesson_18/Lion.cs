using System;

namespace AnimalWorld
{
    class Lion : Carnivore
    {
        public Lion(int power) : base(power) { }

        public override void Eat(Herbivore herbivore)
        {
            if (!herbivore.Life) return;

            if (Power > herbivore.Weight)
            {
                Power += 10;
                herbivore.Life = false;
                Console.WriteLine("Lion wins. Power = " + Power);
            }
            else
            {
                Power -= 10;
                Console.WriteLine("Lion loses. Power = " + Power);
            }
        }
    }
}