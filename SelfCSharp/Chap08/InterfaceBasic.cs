using System;

namespace SelfCSharp.Chap08.Implement;

public interface IFigure
{
    double GetArea();
}

public class Triangle : IFigure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Triangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double GetArea()
    {
        return this.Width * this.Height / 2;
    }
}

public class InterfaceBasic
{
    static void Main(string[] args)
    {
        var t = new Triangle(10, 30);
        Console.WriteLine(t.GetArea());
    }
}