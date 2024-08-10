using System;

namespace SelfCSharp.Chap07.MethodArgs;

public class ArgsParamsGood
{
    public int TotalProducts(int inital, params int[] values)
    {
        int result = inital;
        foreach (var value in values)
        {
            result *= value;
        }
        return result;
    }

    static void Main(string[] args)
    {
        var v = new ArgsParamsGood();
        Console.WriteLine(v.TotalProducts(12, 15, -1));
        Console.WriteLine(v.TotalProducts(5, 7, 8, 2));
    }

}
