using System;

namespace SelfCSharp.Chap09.Practice;

public enum Weekday { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, All = 99 }

public class PEnum
{
    static void Main(string[] args)
    {
        foreach (var name in Enum.GetValues(typeof(Weekday)))
        {
            Console.WriteLine($"{(int)name}：{name}");
        }
    }
}
