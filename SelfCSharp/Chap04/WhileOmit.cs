namespace SelfCSharp.Chap04;

public class WhileOmit
{
    static void Main(string[] args)
    {
        var i = 1;
        while (i < 6)
            Console.WriteLine(i++);
        Console.WriteLine("------------");
    }
}
