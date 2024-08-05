namespace SelfCSharp.Chap05;

public class StreamReadLine
{
    static void Main(string[] args)
    {
        using (var reader = new StreamReader(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample.txt"))
        {
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());

            }
        }
    }
}
