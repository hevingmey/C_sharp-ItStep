using System.Collections;

namespace HW_09_01_26
{
    abstract class Fish
    {
        public string Name { get; }

        protected Fish(string name)
        {
            Name = name;
        }

        public abstract string Info();
    }

    class Shark : Fish
    {
        public Shark(string name) : base(name) { }

        public override string Info() => "shark: " + Name;
    }

    class Dolphin : Fish
    {
        public Dolphin(string name) : base(name) { }

        public override string Info() => "dolphin: " + Name;
    }

    class Octopus : Fish
    {
        public Octopus(string name) : base(name) { }

        public override string Info() => "octopus: " + Name;
    }

    class Ocean : IEnumerable<Fish>
    {
        private List<Fish> animals = new List<Fish>();

        public void Add(Fish f)
        {
            animals.Add(f);
        }

        public IEnumerator<Fish> GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ocean ocean = new Ocean();

            ocean.Add(new Shark("max"));
            ocean.Add(new Dolphin("jessica"));
            ocean.Add(new Octopus("fred"));

            foreach (Fish f in ocean)
            {
                Console.WriteLine(f.Info());
            }
        }
    }
}