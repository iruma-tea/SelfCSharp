using System;

namespace SelfCSharp.Chap08;

public class Circle
{
    public double this[double radius]
    {
        get
        {
            return radius * radius * Math.PI;
        }
    }
}

public class IndexerCircle
{
    static void Main(string[] args)
    {
        var c = new Circle();
        Console.WriteLine(c[10]);
    }
}
