using System;

namespace SelfCSharp.Chap06;

public class ListSort2
{
    static void Main(string[] args)
    {
        var list = new List<string>()
            {
                "バラ",
                "ひまわり",
                "あざみ"
            };

        list.Sort((x, y) => x.Length - y.Length);

        foreach (var s in list)
        {
            Console.WriteLine(s);
        }
    }

}
