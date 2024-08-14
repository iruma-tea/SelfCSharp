using System;

namespace SelfCSharp.Chap08;

public class PatternVar
{
    static void Main(string[] args)
    {
        object obj = 'a';

        Console.WriteLine(obj switch
        {
            int i => $"数値です。: {i}",
            string str => $"文字列です。: {str}",
            var data => $"その他の型でした。: {data}"
        });
    }
}
