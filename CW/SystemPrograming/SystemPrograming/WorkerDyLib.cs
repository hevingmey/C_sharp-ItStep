using System;
using System.Runtime.InteropServices;

namespace SystemPrograming;

internal class WorkerDyLib
{
    [DllImport("libNewCalculator.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr CreateCalculator();

    [DllImport("libNewCalculator.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DeleteCalculator(IntPtr calc);

    [DllImport("libNewCalculator.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern int CalculatorAdd(IntPtr calc, int a, int b);

    public void Run()
    {
        IntPtr objCalc = CreateCalculator();

        Console.WriteLine(CalculatorAdd(objCalc, 4, 6));

        DeleteCalculator(objCalc);
    }
}