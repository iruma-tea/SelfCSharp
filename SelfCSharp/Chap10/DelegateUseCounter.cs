using System;

namespace SelfCSharp.Chap10;

delegate void OutputProcess(string str);

public class DelegateUseCounter
{
    void ArrayWalk(string[] data, OutputProcess output)
    {
        foreach (var value in data)
        {
            output(value);
        }
    }

    static void Main(string[] args)
    {
        var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
        var du = new DelegateUseCounter();
        var c = new Counter();
        du.ArrayWalk(data, c.AddLength);
        Console.WriteLine(c.Result);
    }
}

class Counter
{
    public int Result { get; set; }

    public void AddLength(string value)
    {
        Result += value.Length;
    }
}
