using System;

namespace SelfCSharp.Chap10;

public class LinqDistinct
{
    static void Main(string[] args)
    {
        var bs = AppTables.Books.Select(b => b.Publisher).Distinct();

        foreach (var b in bs)
        {
            Console.WriteLine(b);
        }
    }
}
