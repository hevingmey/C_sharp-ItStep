using System.Diagnostics;

namespace SystemPrograming;

public class ProcessDemo
{
    public void Run()
    {
        ConsoleKeyInfo key;
        do
        {
            Console.WriteLine("Process Demo");
            Console.WriteLine("1: Show all processes");
            Console.WriteLine("2: create process");
            Console.WriteLine("3: kill process");
            Console.WriteLine("4: GetProcessById");
            Console.WriteLine("5: show all processes Filter");
            Console.WriteLine("6: Exit Program");
            key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    ShowAllProcesses();
                    break;
                case '2':
                    Console.WriteLine("create process");
                    CreateProcess();
                    break;
                case '3':
                    Console.WriteLine("kill process");
                    KillProcess();
                    break;
                case '4':
                    Console.WriteLine("GetProcessById");
                    GetProcessById();
                    break;
                case '5':
                    Console.WriteLine("show all processes Filter");
                    ShowAllProcessesFilter();
                    break;
                default:
                    Console.WriteLine("Invalid key");
                    break;

            }
        }while(key.KeyChar != '0');



        //ShowAllProcesses();
        //ShowwithLing();


    }

    private void KillProcess()

    {
        Console.WriteLine("Enter Process Id");
        int pid = Convert.ToInt32(Console.ReadLine());
        var process = Process.GetProcessById(pid);
        if (process.HasExited)
        process.Kill();
        else
        {
            Console.WriteLine("program wasn't active");
        }
        
    }

    private void GetProcessById()
    {
        try
        {
 Console.WriteLine("Enter Process Id");
        int pid = Convert.ToInt32(Console.ReadLine());
        var process = Process.GetProcessById(pid);
        Console.WriteLine($"{process.ProcessName} ");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }

    private void ShowAllProcesses()
    {
        Process[] processes = Process.GetProcesses();
        foreach (var process in processes)
        {
            Console.WriteLine($"{process.ProcessName} PID: {process.Id}");
        }
    }

    private void CreateProcess()
    {
        Console.WriteLine("Enter Process Name");
        string processName = Console.ReadLine(); 
                var process = Process.GetProcessesByName(processName);
                if (process.Length > 0)
                {
                    Console.WriteLine("proces was active");
                    return;
                }

                try
                {

                    Process.Start("open", $"-a {processName} ");
                    Console.WriteLine("process created");
                }
    
        catch (Exception )
        {
            Console.WriteLine("warnig");
            
        }
          
      

    }


    private void ShowAllProcessesFilter()
    {
        Process[] processes = Process.GetProcesses();
        Dictionary<string,int> processesByProcessName = new Dictionary<string, int>();
        
        foreach (var process in processes)
        {
            try
            {
                if (processesByProcessName.ContainsKey(process.ProcessName))
                {
                    processesByProcessName[process.ProcessName]++;
                }
                else
                {
                    processesByProcessName.Add(process.ProcessName, 1);
                }
                
           // Console.WriteLine($"{process.ProcessName} PID: {process.Id}");

            }
            catch (Exception)
            {
                Console.WriteLine("Unkown Error");
                
            }
        }

        foreach (var proc in processesByProcessName)
        {
            Console.WriteLine($"{proc.Key}: {proc.Value }");
        }
    }
}