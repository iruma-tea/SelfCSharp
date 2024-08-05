namespace SelfCSharp.Chap05;

public class StreamRead
{
    static void Main(string[] args)
    {
        using (var reader = new StreamReader(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample.txt"))
        {
            Console.WriteLine(reader.ReadToEnd());

        }
    }
}
