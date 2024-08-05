namespace SelfCSharp.Chap05;

public class DirectoryProcess
{
    static void Main(string[] args)
    {
        var dir = new DirectoryInfo(@"/home/shusuke/work_csharp/SelfCSharp");

        Console.WriteLine(dir.Exists);
        Console.WriteLine(dir.Parent);
        Console.WriteLine(dir.Root);
        Console.WriteLine(dir.CreationTime);
        Console.WriteLine(dir.LastAccessTime);
        Console.WriteLine(dir.LastWriteTime);

        var dirs = dir.GetDirectories();
        foreach (var d in dirs)
        {
            Console.WriteLine(d.FullName);
        }

        var dir2 = new DirectoryInfo(@"/home/shusuke/work_csharp/smp");
        dir2.Create();
        dir2.MoveTo(@"/home/shusuke/work_csharp/test");
        dir2.MoveTo(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/test");
        dir2.CreateSubdirectory("sub");
        dir2.Delete(true);
    }
}
