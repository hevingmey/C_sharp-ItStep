using System;
using System.Runtime.InteropServices;

namespace SystemPrograming;

internal class pmDyLib
{
    [DllImport("libPointManager.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr CreatePm();

    [DllImport("libPointManager.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DestroyPm(IntPtr pm);

    [DllImport("libPointManager.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PmAddPoint(IntPtr pm, int x, int y);

    [DllImport("libPointManager.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PmRemovePoint(IntPtr pm, int index);

    [DllImport("libPointManager.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PmGetPoint(IntPtr pm, int index, out int x, out int y);

    [DllImport("libPointManager.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern int PmCount(IntPtr pm);

    public void Run()
    {
        IntPtr objPm = CreatePm();

        PmAddPoint(objPm, 10, 20);
        PmAddPoint(objPm, 30, 40);

        Console.WriteLine(PmCount(objPm));

        PmGetPoint(objPm, 0, out int x, out int y);
        Console.WriteLine($"{x} {y}");

        PmRemovePoint(objPm, 0);

        Console.WriteLine(PmCount(objPm));

        DestroyPm(objPm);
    }
}