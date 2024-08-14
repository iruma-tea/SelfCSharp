using System;

namespace SelfCSharp.Chap08.Polymo;

public class Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Figure(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public virtual double GetArea()
    {
        return 0.0;
    }
}

public class Triangle : Figure
{
    public Triangle(double width, double height)
        : base(width, height) { }

    public override double GetArea()
    //隠蔽の場合
    //public new double GetArea()
    {
        return this.Width * this.Height / 2;
    }
}

public class Square : Figure
{
    public Square(double width, double height)
        : base(width, height) { }

    public override double GetArea()
    //隠蔽の場合
    //public new double GetArea()
    {
        return this.Width * this.Height;
    }

}
public class PolymorphismBasic
{
    static void Main(string[] args)
    {
        Figure t = new Triangle(10, 30);
        Console.WriteLine(t.GetArea());
        Figure s = new Square(10, 30);
        Console.WriteLine(s.GetArea());
    }
}
