namespace SelfCSharp.Chap05;

public class FileProcess
{
    static void Main(string[] args)
    {
        var file = new FileInfo(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample.txt");

        Console.WriteLine(file.Exists);
        Console.WriteLine(file.Name);
        Console.WriteLine(file.DirectoryName);
        Console.WriteLine(file.IsReadOnly);
        Console.WriteLine(file.LastAccessTime);
        Console.WriteLine(file.LastWriteTime);
        Console.WriteLine(file.Length);

        var file2 = file.CopyTo(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample_copy.txt", true);
        file2.MoveTo(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample_copy.txt");
        file2.MoveTo(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample_copy.txt");

        file2.Delete();
    }
}
