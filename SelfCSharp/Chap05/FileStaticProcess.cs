namespace SelfCSharp.Chap05;

public class FileStaticProcess
{
    static void Main(string[] args)
    {
        Console.WriteLine(File.Exists(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample.txt"));
        Console.WriteLine(File.GetLastAccessTime(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample.txt"));
        Console.WriteLine(File.GetLastWriteTime(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample.txt"));

        File.Copy(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample.txt", @"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample_copy.txt", true);
        File.Move(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample_copy.txt", @"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample_copy.txt");
        File.Move(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample_copy.txt", @"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample_renamed.txt");
        File.Delete(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample_renamed.txt");

    }
}
