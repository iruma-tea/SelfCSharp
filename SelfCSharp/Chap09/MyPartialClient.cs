using System;

namespace SelfCSharp.Chap09;

public class MyPartialClient
{
    static void Main(string[] args)
    {
        var mc = new MyPartial
        {
            FirstName = "太郎",
            LastName = "山田"
        };
        Console.WriteLine(mc.Show());
        Console.WriteLine(mc.Greet());
    }
}
