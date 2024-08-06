namespace SelfCSharp.Chap06;

public class GenericBasic
{
    static void Main(string[] args)
    {
        var list = new List<string>();
        list.Add("あいうえお");
        string str = list[0];
        // list.Add(12345); // コンパイルエラー
        Console.WriteLine(str);
    }
}
