namespace SelfCSharp.Chap04;

public class Goto
{
    static void Main(string[] args)
    {
        goto THERE;
        Console.WriteLine("ここはスキップされます。");

    THERE:
        Console.WriteLine("コードが終了しました。");
    }
}
