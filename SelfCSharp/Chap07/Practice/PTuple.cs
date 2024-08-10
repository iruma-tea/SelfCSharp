using System;

namespace SelfCSharp.Chap07.Practice;

public class PTuple
{
    public static (double addtion, double substraction) AddSubstract(double x, double y)
    {
        return (x + y, x - y);
    }
}
