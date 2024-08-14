using System;

public class Util
{
    public static void Run()
    {
        Console.WriteLine("Util is running.");
    }
}

namespace SelfCSharp.Chap09.Util
{
    public class NamespaceGlobal
    {
        static void Main(string[] args)
        {
            // Util.run();
            global::Util.Run();
        }
    }
}