using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Text.Json;

namespace SystemPrograming;

class Document
{
    public int numberPages{get;set;}
    public string title{get;set;}
}


internal class Program
{
    //генератори 
    static IEnumerable<int> GetData()
    {
        for (int i = 0; i < 10; i++)
        {
        yield return i;    
        }
        
    }
    
    
    static void Main(string[] args)
    {
        
        //
        // Task[] task = new Task[30];
        //
        //     Console.WriteLine("starting...");
        //     for (int i = 0; i < 30; i++)
        //     {
        //         int ord = i;
        //         task[i] = Task.Run(() =>
        //         {
        //             Console.WriteLine($"Thread  {Thread.CurrentThread.ManagedThreadId} completed , order №{ord}");
        //             Thread.Sleep(1000);
        //         });
        //
        //     }
        // Task.WaitAll(task);
        //     Console.WriteLine("finished");
         }
        
       
    }
    // private static readonly string URL = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
    // // static async Task <List<Document>> LoadDocuments()
    // // {
    // //     var documents = new List<Document>();
    // //     Console.WriteLine("Loading documents");
    // //     await Task.Delay(1000);
    // //     documents.Add(new Document { numberPages = 1, title = "new Documents" });
    // //     Console.WriteLine($"Loaded {documents.Count} documents");
    // //     
    // //     await Task.Delay(1000);
    // //     documents.Add(new Document { numberPages = 2, title = "new Documents" });
    // //     Console.WriteLine($"Loaded {documents.Count} documents");
    // //     
    // //     await Task.Delay(1000);
    // //     documents.Add(new Document { numberPages = 3, title = "new Documents" });
    // //     Console.WriteLine($"Loaded {documents.Count} documents");
    // //     
    // //     await Task.Delay(1000);
    // //     documents.Add(new Document { numberPages = 4, title = "new Documents" });
    // //     Console.WriteLine($"Loaded {documents.Count} documents");
    // //     
    // //     
    // //     
    // //     
    // //     return documents;
    // // }
    // static async Task<List<Currency>> GetCurrencies()
    // {
    //     using (HttpClient client = new HttpClient())
    //     {
    //         try
    //         {
    //             var response = await client.GetStringAsync(URL);
    //             var obj = JsonSerializer.Deserialize<List<Currency>>(response);
    //             if (obj != null)
    //             {
    //                return obj;
    //             }
    //         }
    //         catch (Exception )
    //         {
    //          
    //             
    //         }
    //         return null;
    //     }
    //     
    // }
 
    
    // static async Task Main(string[] args)
    // {
    //    
    //     var data =await GetCurrencies();
    //     if (data != null)
    //     {
    //         foreach (var item in data)
    //         {
    //             Console.WriteLine(item);
    //         }
    //     }
    //     
    // }
        
    
    
    
// {           //hw 1
//     static Bank bank = new Bank(200, false);
//
//     static void Worker()
//     {
//         Random random = new Random();
//         while (true)
//         {
//             if (bank.GetStatus())
//             {
//                 Console.WriteLine("Bank status: " + bank.GetStatus());
//                 break;
//             }
//             int number = random.Next(2);
//             if (number == 0)
//             {
//                 bank.Deposit(random.Next(35,100));
//             }
//             else
//             {
//                 bank.Withdraw(random.Next(60,120));
//             }
//             Thread.Sleep(100);
//         }
//     }
//   
//         static void Main(string[] args)
//         {
//             
//             Thread[] threads = new Thread[3];
//             for (int i = 0; i < threads.Length; i++)
//             {
//                threads[i] = new Thread(Worker);
//                threads[i].Start();
//             }
//
//             for (int i = 0; i < threads.Length; i++)
//             {
//                 threads[i].Join();
//             }
//             
//             
//          
//             
//


   

