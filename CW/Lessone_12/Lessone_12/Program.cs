// namespace Lessone_12;
//
// class Car
// {
//     public string Model { get; set; }
//     public int Year { get; set; }
//     public Car(string model, int year)
//     {
//         Model = model;
//         Year = year;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Car car = new Car();
//         // Console.WriteLine(GC.GetGeneration(car));
//         // GC.Collect();
//         // Console.WriteLine(GC.GetGeneration(car));
//         // GC.Collect(1);
//         // Console.WriteLine(GC.GetGeneration(car));
//         // GC.Collect(2);
//         // Console.WriteLine(GC.GetGeneration(car));
//         Car car = new Car("audi", 2020);
//         int i = 0;
//         while (i < 130_000)
//         {
//             Car car2 = new Car("bmw", 2000);
//             i++;
//         }
//         Console.WriteLine("байт в купі: {0}",
//             GC.GetTotalMemory(false));
//         Console.WriteLine(GC.GetGeneration(car));    
//         // Console.WriteLine("Hello, World!");
//     }
// }

using System;
using System.Diagnostics;

namespace Lessone_12
{
    class MemoryAllocator 
    {
        private object[] data;

        public void Array(int count)
        {
            data = new object[count];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = new byte[16];
            }
        }

        public void Use()
        {
            for (int i = 0; i < data.Length; i += 3)
            {
                data[i] = null;
            }

            for (int i = 0; i < 200_000; i++)
            {
                byte[] trash = new byte[64];
                trash[0] = (byte)(i % 255);
            }
        }

        public int GeneFirst()
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != null)
                    return GC.GetGeneration(data[i]);
            }
            return -1;
        }

        public void Check()
        {
            Console.WriteLine("купа до: " + GC.GetTotalMemory(false));

            int genBefore = GeneFirst();
            Console.WriteLine("покоління до: " + genBefore);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            sw.Stop();

            int genAfter = GeneFirst();
            Console.WriteLine("покоління після: " + genAfter);

            Console.WriteLine("купа після: " + GC.GetTotalMemory(false));
            Console.WriteLine("час GC " + sw.Elapsed.TotalSeconds + " s");
        }

        public void Dispose()
        {
            data = null;
            GC.SuppressFinalize(this);
        }

        ~MemoryAllocator()
        {
            Console.WriteLine("finalizer complete");
        }
    }

    class Program
    {
        static void Main()
        {
            MemoryAllocator allocator = new MemoryAllocator();

            Stopwatch all = new Stopwatch();
            all.Start();

            allocator.Array(1_000_000);
            allocator.Use();
            allocator.Check();

            all.Stop();
            Console.WriteLine("загальний час: " + all.Elapsed.TotalSeconds + " s");

            allocator.Dispose();
        }
    }
}