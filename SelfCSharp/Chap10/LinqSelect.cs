using System;
using SelfCSharp.Chap03;

namespace SelfCSharp.Chap10;

public class LinqSelect
{
    static void Main(string[] args)
    {
        // クエリ構文
        var bs = from b in AppTables.Books
                 select new
                 {
                     ShortTitle = b.Title.Substring(0, 5),
                     DiscountPrice = b.Price * 0.9,
                     Released = (b.Published <= DateTime.Now ? "発売中" : "発売予定")
                 };


        // メソッド構文
        // var bs = AppTables.Books.Select(b => new
        // {
        //     Shortcut = b.Title.Substring(0, 5),
        //     DiscountPrice = b.Price * 0.9,
        //     Released = (b.Published <= DateTime.Now ? "発売中" : "発売予定")
        // });

        foreach (var b in bs)
        {
            Console.WriteLine(b);
        }
    }
}
