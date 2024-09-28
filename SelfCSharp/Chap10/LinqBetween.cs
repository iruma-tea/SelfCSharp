using System;

namespace SelfCSharp.Chap10;

public class LinqBetween
{
    static void Main(string[] args)
    {
        // クエリ構文
        var bs = from b in AppTables.Books
                 where (2000 <= b.Price && b.Price <= 3500)
                 select b;

        // メソッド構文
        // var bs = AppTables.Books
        //     .Where(b => 2000 <= b.Price && b.Price <= 3500)
        //     .Select(b => b);

        // 列挙も可能
        // クエリ構文
        // var bs = from b in AppTables.Books
        //          where (2000 <= b.Price)
        //          where (b.Price <= 3500)
        //          select b;

        // 列挙も可能
        // メソッド構文
        // var bs = AppTables.Books
        //         .Where(b => 2000 <= b.Price)
        //         .Where(b => b.Price <= 3500)
        //         .Select(b => b);

        foreach (var b in bs)
        {
            Console.WriteLine(b);
        }
    }
}
