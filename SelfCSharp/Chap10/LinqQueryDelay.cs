using System;

namespace SelfCSharp.Chap10;

public class LinqQueryDelay
{
    static void Main(string[] args)
    {
        var bs = from b in AppTables.Books select b.Title;
        // var bs = (from b in AppTables.Books select b.Title).ToArray();

        // 0番目の書籍タイトルを変更
        AppTables.Books.ElementAt(0).Title = "独学できるPHP";
        foreach (var b in bs)
        {
            Console.WriteLine(b);
        }
    }
}
