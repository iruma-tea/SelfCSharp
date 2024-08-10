using System;

namespace SelfCSharp.Chap07.MethodStatic;

public class Figure
{
    // クラスフィールドの追加
    public static double Pi = 3.14;
    public static void GetTriangleArea(int width, int height)
    {
        Console.WriteLine($"三角形の面積は{width * height / 2}");
    }
    public static void GetCircleArea(double r)
    {
        Console.WriteLine($"円の面積は{r * r * Pi}");
    }
}

public class StaticBasic
{
    static void Main(string[] args)
    {
        Figure.GetTriangleArea(10, 20);
        Console.WriteLine(Figure.Pi);
        Figure.GetCircleArea(5);
    }
}
