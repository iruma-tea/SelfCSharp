using System;

namespace SelfCSharp.Chap10;

delegate void OutPutProcess(string str);

public class DelegateUse
{
    void ArrayWalk(string[] data, OutPutProcess outputt)
    {
        foreach (var value in data)
        {
            outputt(value);
        }
    }

    static void AddQuote(string data)
    {
        Console.WriteLine($"[{data}]");
    }

    static void Main(string[] args)
    {
        var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
        var du = new DelegateUse();
        OutPutProcess proc = AddQuote;
        du.ArrayWalk(data, proc);
    }
}
