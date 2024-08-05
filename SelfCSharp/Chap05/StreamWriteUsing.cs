namespace SelfCSharp.Chap05;

public class StreamWriteUsing
{
    static void Main(string[] args)
    {
        using var writer = new StreamWriter(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/data.log");
        writer.WriteLine(DateTime.Now.ToString());
    }
}
