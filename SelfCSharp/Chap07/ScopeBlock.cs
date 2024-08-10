using System;

namespace SelfCSharp.Chap07;

public class ScopeBlock
{
    static void Main(string[] args)
    {
        var data = "ローカルスコープ";
        {
            // var data = "ブロックスコープ";
        }
    }
}
