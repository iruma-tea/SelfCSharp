﻿namespace SelfCSharp.Chap05;

public class StrAll
{
    static void Main(string[] args)
    {
        var str = "WINGS2号";
        Console.WriteLine(str.All(ch => Char.IsDigit(ch)));
    }
}
