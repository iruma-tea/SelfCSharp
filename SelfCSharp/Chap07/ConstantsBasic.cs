using System;

namespace SelfCSharp.Chap07;

public class Constants
{
    // public static const int Value = 10; // エラー
    public const int Value = 10;
}

public class ConstantsBasic
{
    static void Main(string[] args)
    {
        Console.WriteLine(Constants.Value);
    }
}
