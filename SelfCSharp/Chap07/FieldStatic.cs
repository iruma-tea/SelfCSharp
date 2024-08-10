using System;

namespace SelfCSharp.Chap07.ClassField;

public class MyApp
{
    public static readonly string Title = "独習C#";
}

public class FieldStatic
{
    static void Main(string[] args)
    {
        Console.WriteLine(MyApp.Title);
        // MyApp.Title = "本気でおぼえるC#";
    }
}
