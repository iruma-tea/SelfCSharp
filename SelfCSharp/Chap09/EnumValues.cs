using System;

namespace SelfCSharp.Chap09;

public class EnumValues
{
    static void Main(string[] args)
    {
        foreach (var name in Enum.GetValues(typeof(Season)))
        {
            Console.WriteLine($"{(int)name}: {name}");
        }
    }
}
