namespace SelfCSharp.Chap05;

public class StrAny
{
    static void Main(string[] args)
    {
        var str = "WINGS2号";
        Console.WriteLine(str.Any(ch => Char.IsDigit(ch)));
    }
}
