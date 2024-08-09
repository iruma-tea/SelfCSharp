using System;

namespace SelfCSharp.Chap06;

public class CollectionInitializeIndex
{
    static void Main(string[] args)
    {
        // var flower = new Dictionary<string, string>() {
        //     {"Rose", "バラ"},
        //     {"Sunflower", "ひまわり"},
        //     {"Morning Glory", "あさがお"}
        // };

        var flower = new Dictionary<string, string>()
        {
            ["Rose"] = "バラ",
            ["Sunflower"] = "ひまわり",
            ["Morning Glory"] = "あさがお"
        };

        foreach (var m in flower)
        {
            Console.WriteLine(m);
        }
    }
}
