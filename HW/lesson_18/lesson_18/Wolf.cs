using System;

namespace AnimalWorld
{
    class Wolf : Carnivore
    {
        public Wolf(int power) : base(power) { }

        public override void Eat(Herbivore herbivore)
        {
            if (!herbivore.Life) return;

            if (Power > herbivore.Weight)
            {
                Power += 10;
                herbivore.Life = false;
                Console.WriteLine("Wolf wins. Power = " + Power);
            }
            else
            {
                Power -= 10;
                Console.WriteLine("Wolf loses. Power = " + Power);
            }
        }
    }
}