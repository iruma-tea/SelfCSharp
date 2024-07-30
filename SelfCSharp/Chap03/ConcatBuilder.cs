using System.Text;

namespace SelfCSharp.Chap03;

public class ConcatBuilder
{
    static void Main(string[] args)
    {
        var start = new DateTime();
        var builder = new StringBuilder();
        for (int i = 0; i < 100000; i++)
        {
            builder.Append("いろは");
        }
        var result = builder.ToString();
        var end = new DateTime();
        Console.WriteLine(end.Ticks - start.Ticks);
    }
}
