﻿namespace SelfCSharp.Chap04;

public class ForFloat
{
    static void Main(string[] args)
    {
        for (var i = 0.1f; i <= 1.0; i += 0.1f)
        {
            Console.WriteLine(i);
        }
    }
}
