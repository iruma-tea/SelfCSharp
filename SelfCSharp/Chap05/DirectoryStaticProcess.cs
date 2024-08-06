namespace SelfCSharp.Chap05;

public class DirectoryStaticProcess
{
    static void Main(string[] args)
    {
        Console.WriteLine(Directory.Exists(@"/home/shusuke/work_csharp/SelfCSharp"));
        Console.WriteLine(Directory.GetParent(@"/home/shusuke/work_csharp/SelfCSharp"));
        Console.WriteLine(Directory.GetDirectoryRoot(@"/home/shusuke/work_csharp/SelfCSharp"));
        Console.WriteLine(Directory.GetCreationTime(@"/home/shusuke/work_csharp/SelfCSharp"));
        Console.WriteLine(Directory.GetLastAccessTime(@"/home/shusuke/work_csharp/SelfCSharp"));
        Console.WriteLine(Directory.GetLastWriteTime(@"/home/shusuke/work_csharp/SelfCSharp"));

        var dirs = Directory.GetDirectories(@"/home/shusuke/work_csharp/SelfCSharp");
        foreach (var d in dirs)
        {
            Console.WriteLine(d);
        }

        Directory.CreateDirectory(@"/home/shusuke/work_csharp/SelfCSharp/smp");
        Directory.Move(@"/home/shusuke/work_csharp/SelfCSharp/smp", @"/home/shusuke/work_csharp/SelfCSharp/test");
        Directory.Delete(@"/home/shusuke/work_csharp/SelfCSharp/test");
    }
}
