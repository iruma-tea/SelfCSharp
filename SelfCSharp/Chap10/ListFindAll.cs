using System;

namespace SelfCSharp.Chap10;

public class ListFindAll
{
    static void Main(string[] args)
    {
        var list = new List<string> { "からすなぜ鳴くの", "からすは山に", "可愛い七つの", "子があるからよ" };
        var result = list.FindAll(str => str.StartsWith("からす"));

        foreach (var s in result)
        {
            Console.WriteLine(s);
        }
    }
}
