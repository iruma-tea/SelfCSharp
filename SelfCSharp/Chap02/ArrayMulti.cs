namespace SelfCSharp.Chap02;

public class ArrayMulti
{
    static void Main(string[] args)
    {
        var data = new[,]
        {
            {10, 11, 12},
            {20, 21, 22}
        };

        Console.WriteLine(data[0, 1]);
    }
}
