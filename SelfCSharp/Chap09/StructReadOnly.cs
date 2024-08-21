using System;

namespace SelfCSharp.Chap09.Struct.Readonly;

readonly struct Coordinate
{
    public readonly double X;
    public readonly double Y;

    public Coordinate(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public void SetValue(double x, double y)
    {
        // this = new Coordinate(X, y);
    }
}

public class StructReadOnly
{
    static void Main(string[] args)
    {
        var c = new Coordinate(10, 20);
        c.SetValue(1, 2);
        Console.WriteLine(c.X);
        Console.WriteLine(c.Y);

    }
}
