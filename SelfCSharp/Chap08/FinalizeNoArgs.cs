using System;

namespace SelfCSharp.Chap08.Finalize;

public class MyParent
{
    ~MyParent()
    {
        Console.WriteLine("親です。");
    }
}

public class MyChild : MyParent
{
    ~MyChild()
    {
        Console.WriteLine("子です。");
    }
}

public class FinalizeNoArgs
{
    static void Main(string[] args)
    {
        var c = new MyChild();
    }
}
