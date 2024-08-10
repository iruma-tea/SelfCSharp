using System;

namespace SelfCSharp.Chap07;

public class ScopeBlock2
{
    static void Main(string[] args)
    {
        {
            // var data = "ブロックスコープ";
        }
        var data = "ローカルスコープ";
    }
}
