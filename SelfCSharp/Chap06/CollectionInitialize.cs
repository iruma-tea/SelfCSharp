namespace SelfCSharp.Chap06;

public class CollectionInitialize
{
    static void Main(string[] args)
    {
        var list = new List<string>() {
            "あいうえお",
            "かきくけこ",
            "さしすせそ",
        };

        foreach (var v in list)
        {
            Console.WriteLine(v);
        }
    }
}
