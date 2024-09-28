using System;

namespace SelfCSharp.Chap10;

public class LinqSkip
{
    static void Main(string[] args)
    {
        var bs = AppTables.Books.OrderBy(b => b.Published).Skip(2).Take(3).Select(b => b);
        foreach (var b in bs)
        {
            Console.WriteLine(b);
        }
    }
}
