using System;

namespace SelfCSharp.Chap09;

public class OverflowDouble
{
    static void Main(string[] args)
    {
        checked
        {
            var m = double.MaxValue;
            var n = double.Epsilon;
            Console.WriteLine(m * m);
            Console.WriteLine(n * n);
        }
    }

}
