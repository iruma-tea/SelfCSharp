using System;
using System.Runtime.CompilerServices;

namespace SelfCSharp.Chap07;

public class MyInitializer
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.WriteLine("Init is called");
    }

    [ModuleInitializer]
    public static void Init2()
    {
        Console.WriteLine("Init2 is called");
    }
}

public class ModuleInit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main is called");
    }
}
