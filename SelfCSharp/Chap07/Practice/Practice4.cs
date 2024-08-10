using System;
using SelfCSharp.Chap03;

namespace SelfCSharp.Chap07.Practice;

public class Practice4
{
    static int increment(ref int value)
    {
        value += 5;
        return value;
    }

    static void Main(string[] args)
    {
        int value = 10;
        Console.WriteLine(increment(ref value));
        Console.WriteLine(value);
    }
}
