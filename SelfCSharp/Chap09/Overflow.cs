using System;

namespace SelfCSharp.Chap09;

public class Overflow
{
    static void Main(string[] args)
    {
        var i = int.MaxValue;
        Console.WriteLine(++i);
    }
}
