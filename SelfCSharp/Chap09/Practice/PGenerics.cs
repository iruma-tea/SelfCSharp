using System;

namespace SelfCSharp.Chap09.Practice;

public class MyGenerics<T> where T : new()
{
    T obj = new T();
}

public class PGenerics
{
    static void Main(string[] args)
    {
        var m = new MyGenerics<int>();
    }
}
