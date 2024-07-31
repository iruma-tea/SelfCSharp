namespace SelfCSharp.Chap04;

public class PreIf
{
    static void Main(string[] args)
    {
#if DEBUG
        Console.WriteLine("デバック時にだけ表示します。");
#endif
    }
}
