#define DEBUG
using System;
using System.Diagnostics;

namespace SelfCSharp.Chap11;

public class AttrConditional
{
    [Conditional("DEBUG")]
    static void Message()
    {
        Console.WriteLine("デバック時にだけ表示します。");
    }

    static void Main(string[] args)
    {
        Message();
        Console.WriteLine("終了しました。");
    }
}
