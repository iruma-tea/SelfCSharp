using System;

namespace SelfCSharp.Chap09.Operator4;

public class Coordinate
{
    public int X { set; get; }
    public int Y { set; get; }

    public static explicit operator int(Coordinate c)
    {
        return c.X * c.X + c.Y * c.Y;
    }
}

public class OpeCast
{
    static void Main(string[] args)
    {
        var c = new Coordinate() { X = 10, Y = 20 };
        Console.WriteLine((int)c);
    }
}
