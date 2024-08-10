using System;

namespace SelfCSharp.Chap07;

public class ScopeBasic
{
    public string data = "フィールド";

    public string Show()
    {
        string data = "ローカル";
        // return data;
        return this.data;
    }

    static void Main(string[] args)
    {
        var s = new ScopeBasic();
        Console.WriteLine(s.Show());
        Console.WriteLine(s.data);
    }
}
