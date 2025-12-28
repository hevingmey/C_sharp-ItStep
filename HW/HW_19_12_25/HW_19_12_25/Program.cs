namespace HW_19_12_25;
abstract class OfficeDevice
{
    protected string name;

    public void TurnOff()
    {
        Console.WriteLine($"{name} is turned off");
    }

    public void TurnOn()
    {
        Console.WriteLine($"{name} is turned on");
    }
    

}

public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public interface ICopier 
{
    void Copy();
}



class Printer : OfficeDevice, IPrinter
{
    public Printer(string name)
    {
        this.name = name;
    }
    
    public void Print()
    {
        Console.WriteLine($"{name} is printed");
    }
}

class Copier:OfficeDevice,ICopier
{
    public Copier(string name)
    {
        this.name = name;
    }
    public void Copy()
    {
        Console.WriteLine($"{name} is copied");
    }
}



class  Scaner:OfficeDevice,IScanner
{
    public Scaner(string name)
    {
        this.name = name;
    }
    public void Scan()
    {
        Console.WriteLine($"{name} is scanning");
    }
}

class MFY: OfficeDevice,ICopier,IPrinter,IScanner
{
    public MFY(string name)
    {
        this.name = name;
    }

    public void Copy()
    {
        Console.WriteLine($"{name} is copied");
    }

    public void Print()
    {
        Console.WriteLine($"{name} is printed");
    }

    public void Scan()
    {
        Console.WriteLine($"{name} is scanning");
    }
}

class Office
{
    private OfficeDevice[] devices;
    public Office(OfficeDevice[] devices)
    {
        this.devices = devices;
    }

    public void TurnOffAll()
    {
        foreach (var device in devices)
            {
            device.TurnOff();
            }
    }

    public void TurnOnAll()
    {
        foreach (var device in devices)
        {
            device.TurnOn();
        }
    }
    public void StartPrinter()
    {
        foreach (var device in devices)
        {
            if (device is IPrinter printer)
                printer.Print();
        }
    }

    public void StartCopier()
    {
        foreach (var device in devices)
        {
            if (device is ICopier copier)
                copier.Copy();
        }
    }
    public void StartScanner()
    {
        foreach (var device in devices)
            {
            if (device is IScanner scanner)
                scanner.Scan();
            }
    }
    
    
}




class Program
{
    static void Main(string[] args)
    {
        OfficeDevice[] devices =
        {
            new Printer("Printer 1"),
            new Copier("Copier 1"),
            new Scaner("Scanner 1"),
            new MFY("MFY 1")
        };
        Office office1=new Office(devices);
        office1.TurnOnAll();
        office1.StartPrinter();
        office1.StartCopier();
        office1.StartScanner();
        office1.TurnOffAll();   
    }
} 