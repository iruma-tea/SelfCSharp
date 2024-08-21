using System;

namespace SelfCSharp.Chap09;

public class ThrowRe
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
            throw;
        }
    }
}
