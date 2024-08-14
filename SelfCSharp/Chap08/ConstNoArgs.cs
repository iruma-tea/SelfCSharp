using System;

namespace SelfCSharp.Chap08;

public class MyParent
{
    public MyParent()
    {
        Console.WriteLine("親です。");
    }
}

public class MyChild : MyParent
{
    public MyChild()
    {
        Console.WriteLine("子です。");
    }
}
public class ConstNoArgs
{
    static void Main(string[] args)
    {
        var c = new MyChild();
    }
}
