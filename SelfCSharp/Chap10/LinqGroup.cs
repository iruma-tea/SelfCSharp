using System;

namespace SelfCSharp.Chap10;

public class LinqGroup
{
    static void Main(string[] args)
    {
        // クエリ構文
        var bs = from b in AppTables.Books group b by b.Publisher;

        // メソッド構文
        // var bs = AppTables.Books.GroupBy(b => b.Publisher);

        foreach (var b in bs)
        {
            Console.WriteLine($"[{b.Key}]");
            foreach (var t in b)
            {
                Console.WriteLine($"{t.Title} ({t.Price}円)");
            }
        }
    }
}
