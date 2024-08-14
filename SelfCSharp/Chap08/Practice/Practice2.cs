using System;

namespace SelfCSharp.Chap08.Practice;

public static class StringExtensions
{
    public static string ToTitleCase(this string str)
    {
        return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
    }
}

public class Practice2
{
    static void Main(string[] args)
    {
        Console.WriteLine("wings".ToTitleCase());
    }
}
