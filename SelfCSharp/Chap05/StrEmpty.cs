﻿namespace SelfCSharp.Chap05;

public class StrEmpty
{
    static void Main(string[] args)
    {
        var str1 = "";
        Console.WriteLine(String.IsNullOrEmpty(str1));

        var str2 = "   ";
        Console.WriteLine(String.IsNullOrWhiteSpace(str2));
    }
}
