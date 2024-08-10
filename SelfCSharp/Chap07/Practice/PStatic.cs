using System;

namespace SelfCSharp.Chap07.Practice;

public static class MyClass
{
    public static double GetBmi(double weight, double height)
    {
        return weight / (height * height);
    }
}

public class PStatic
{
    static void Main(string[] args)
    {
        Console.WriteLine(MyClass.GetBmi(55, 1.7));
    }
}
