using System.Diagnostics;
using System.Threading;
namespace SystemPrograming;

internal class Program
{
    private static void PrintNormal()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Normal");
            Thread.Sleep(100);
        }
    }
    private static void PrintLow()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("low");
            Thread.Sleep(100);
        }
    }
    private static void PrintHight()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("hight");
            Thread.Sleep(100);
        }
    }
    static void Main(string[] args)
    {Thread threadLow = new Thread(PrintLow);
        Thread threadNormal = new Thread(PrintNormal);
              Thread threadHight = new Thread(PrintHight);

        
        
        threadLow.Priority = ThreadPriority.Lowest;
        threadNormal.Priority = ThreadPriority.Normal;

        
        threadHight.Priority = ThreadPriority.Highest;
          
        threadLow.Start();
        threadNormal.Start();
        threadHight.Start();
        
        threadLow.Join();
        threadNormal.Join();
        threadHight.Join();
    }
}


    

   

