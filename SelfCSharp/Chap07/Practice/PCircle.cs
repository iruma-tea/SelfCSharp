using System;

namespace SelfCSharp.Chap07.Practice;

public class Circle
{
    double radius;

    public Circle(double radius = 1)
    {
        this.radius = radius;
    }

    public Circle() : this(1) { }

    public double GetArea()
    {
        return this.radius * this.radius * Math.PI;
    }
}
