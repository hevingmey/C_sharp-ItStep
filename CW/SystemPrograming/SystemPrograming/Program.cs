using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace SystemPrograming;



internal class Program
{           //hw 1
    static Bank bank = new Bank(200, false);

    static void Worker()
    {
        Random random = new Random();
        while (true)
        {
            if (bank.GetStatus())
            {
                Console.WriteLine("Bank status: " + bank.GetStatus());
                break;
            }
            int number = random.Next(2);
            if (number == 0)
            {
                bank.Deposit(random.Next(35,100));
            }
            else
            {
                bank.Withdraw(random.Next(60,120));
            }
            Thread.Sleep(100);
        }
    }

                                     
   // private static ConcurrentQueue<Order> queue = new ConcurrentQueue<Order>();
    // static void ProcesOrder()
    // {
    //     while (true)
    //     {
    //         if (queue.TryDequeue(out Order order))
    //         {
    //             Console.WriteLine($" emploee {Thread.CurrentThread.ManagedThreadId} ordr {order.Id} {order.Name}");
    //             Thread.Sleep(500);
    //         }
    //         else
    //         {
    //             break;
    //         }
    //         
    //     }
    // }

  
        static void Main(string[] args)
        {
            
            Thread[] threads = new Thread[3];
            for (int i = 0; i < threads.Length; i++)
            {
               threads[i] = new Thread(Worker);
               threads[i].Start();
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            
            
            
            // ManualResetEvent mre = new ManualResetEvent(false);
            // ThreadPool.QueueUserWorkItem(_ =>
            // {
            //     Console.WriteLine("thread started");
            //     Thread.Sleep(500);
            //     Console.WriteLine("thread stopped");
            //     mre.Set();
            // });
            // mre.WaitOne();
            // Console.WriteLine("end main");
            //
            //
            //
            
            

            // queue.Enqueue(new Order
            //     {
            //         Id = 1,
            //         Name = "milk"
            //     });
            //
            //     queue.Enqueue(
            //         new Order{Id = 2, Name = "cheese"}
            //         );
            //     queue.Enqueue(
            //         new Order{Id = 3, Name = "egg"});
            //     queue.Enqueue(
            //         new Order{Id = 4, Name = "bread"});
            //     
            //     Thread[] threads = new Thread[3];
            //     for (int i = 0; i < threads.Length; i++)
            //     {
            //         threads[i] = new Thread(ProcesOrder);
            //         threads[i].Start();
            //     }
            //
            //     for (int i = 0; i < threads.Length; i++)
            //     {
            //         threads[i].Join();
            //     }

            // private static object locker = new object();
            // private static int total = 0;
            //
            // static void Up()
            // {
            //     const int N = 10;
            //     for (int i = 0; i <N; i++)
            //     {
            //         lock (locker)
            //         {
            //             ++total;
            //
            //         }
            //       
            //         Thread.Sleep(1);
            //     }
            // }
            //








            // const int Count_threads = 5;
            // Thread[] threads = new Thread[Count_threads];
            // for (int i = 0; i < Count_threads; i++)
            // {
            //     threads[i] = new Thread(Up);
            //     threads[i].Start();
            // }
            //
            // for (int i = 0; i < Count_threads; i++)
            // {
            //     threads[i].Join();
            // }
            //
            // Console.WriteLine("total: " + total);


            // Thread thread = new Thread(() =>
            // {
            //     Console.WriteLine($"thread by name: {Thread.CurrentThread.Name} ");
            //     for (int i = 0; i < 10; i++)
            //     {
            //         Console.WriteLine(i);
            //     }
            // });
            // if (thread.Name == null)
            // {
            //     thread.Name="test";
            // }
            // thread.Start();
            // thread.Join();
            // Console.WriteLine("main end");
            //
        }
    
    
    
    
    
    // private static void PrintNormal()
    // {
    //     for (int i = 0; i < 20; i++)
    //     {
    //         Console.WriteLine("Normal");
    //         Thread.Sleep(100);
    //     }
    // }
    // private static void PrintLow()
    // {
    //     for (int i = 0; i < 20; i++)
    //     {
    //         Console.WriteLine("low");
    //         Thread.Sleep(100);
    //     }
    // }
    // private static void PrintHight()
    // {
    //     for (int i = 0; i < 20; i++)
    //     {
    //         Console.WriteLine("hight");
    //         Thread.Sleep(100);
    //     }
    // }
    // static void Main(string[] args)
    // {Thread threadLow = new Thread(PrintLow);
    //     Thread threadNormal = new Thread(PrintNormal);
    //           Thread threadHight = new Thread(PrintHight);
    //
    //     
    //     
    //     threadLow.Priority = ThreadPriority.Lowest;
    //     threadNormal.Priority = ThreadPriority.Normal;
    //
    //     
    //     threadHight.Priority = ThreadPriority.Highest;
    //       
    //     threadLow.Start();
    //     threadNormal.Start();
    //     threadHight.Start();
    //     
    //     threadLow.Join();
    //     threadNormal.Join();
    //     threadHight.Join();
    // }
}


    

   

