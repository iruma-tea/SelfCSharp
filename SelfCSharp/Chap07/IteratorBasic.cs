using System;

namespace SelfCSharp.Chap07;

public class IteratorBasic
{
    public IEnumerable<string> GetStrings()
    {
        yield return "あいうえお";
        yield return "かきくけこ";
        yield return "さしすせそ";
    }

    static void Main(string[] args)
    {
        var ite = new IteratorBasic();
        foreach (var str in ite.GetStrings())
        {
            Console.WriteLine(str);
        }
    }
}
