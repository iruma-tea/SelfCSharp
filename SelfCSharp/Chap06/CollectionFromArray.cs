using System;

namespace SelfCSharp.Chap06;

public class CollectionFromArray
{
    static void Main(string[] args)
    {
        var array = new[] { "バラ", "ひまわり", "あさがお" };
        var list = new List<string>(array);

        foreach (var v in list)
        {
            Console.WriteLine(v);
        }
    }
}
