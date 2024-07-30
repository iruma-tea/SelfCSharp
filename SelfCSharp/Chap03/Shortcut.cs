namespace SelfCSharp.Chap03;

public class Shortcut
{
    static void Main(string[] args)
    {
        string? str = null;
        if (str != null && str.StartsWith("https://"))
        {
            Console.WriteLine("「https://～」で始まります。");
        }
    }
}
