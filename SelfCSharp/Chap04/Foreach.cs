﻿namespace SelfCSharp.Chap04;

public class Foreach
{
    static void Main(string[] args)
    {
        var data = new[] { "うめ", "さくら", "もも" };
        foreach (var val in data)
        {
            Console.WriteLine(val);
        }
    }
}
