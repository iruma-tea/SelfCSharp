using System;

namespace SelfCSharp.Chap09;

public class TryMultiOld
{
    static void Main(string[] args)
    {
        try
        {
            using (var sr = new StreamReader(@"C:\nothing.dat"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("ファイルにアクセスできません。");
            Console.WriteLine(ex.StackTrace);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("ファイルにアクセスできません。");
            Console.WriteLine(ex.StackTrace);
        }
    }
}
