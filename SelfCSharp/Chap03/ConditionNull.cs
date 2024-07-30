namespace SelfCSharp.Chap03;

public class ConditionNull
{
    static void Main(string[] args)
    {
        string? str = "山田";
        string def = "権兵衛";
        Console.WriteLine(str ?? def);
    }
}
