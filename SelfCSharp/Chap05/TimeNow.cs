namespace SelfCSharp.Chap05;

public class TimeNow
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Today);
        Console.WriteLine(new DateTime(2022, 02, 15, 13, 17, 23));
    }
}
