namespace SelfCSharp.Chap05;

public class Factorial
{
    static void Main(string[] args)
    {
        long result = 1;
        for (var i = 1; i < 26; i++)
        {
            result *= i;
            Console.WriteLine(result);
        }
    }
}
