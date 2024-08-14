using System;

namespace SelfCSharp.Chap08;

public class PatternConst
{
    static void Main(string[] args)
    {
        object obj = 123;

        Console.WriteLine(obj switch
        {
            123 => "123です。",
            int i => "数値です。",
            _ => "意図しない値です。"
        });
    }
}
