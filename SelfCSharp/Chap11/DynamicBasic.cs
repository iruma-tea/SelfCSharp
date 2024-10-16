using System;

namespace SelfCSharp.Chap11;

public class DynamicBasic
{
    static void Main(string[] args)
    {
        dynamic d = 10;
        d = "ほげ";
        d.Hoge();
    }
}
