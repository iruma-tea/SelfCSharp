using System;

namespace SelfCSharp.Chap09;

public class TryFinally
{
    static void Main(string[] args)
    {
        StreamReader? sr = null;
        try
        {
            sr = new StreamReader(@"C:\nothing.dat");
            Console.WriteLine(sr.ReadToEnd());
        }
        finally
        {
            sr?.Close();
        }
    }
}
