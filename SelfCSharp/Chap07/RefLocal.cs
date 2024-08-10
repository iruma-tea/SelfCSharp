using System;

namespace SelfCSharp.Chap07;

public class RefLocal
{
    static void Main(string[] args)
    {
        var i = 10;
        ref var j = ref i;
        i = 15;
        Console.WriteLine(j);
    }
}
