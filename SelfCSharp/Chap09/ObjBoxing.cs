using System;

namespace SelfCSharp.Chap09;

public class ObjBoxing
{
    static void Main(string[] args)
    {
        int data = 100;
        Console.WriteLine(data.ToString());
        object obj = data;

        // int i = (int)obj;
    }
}
