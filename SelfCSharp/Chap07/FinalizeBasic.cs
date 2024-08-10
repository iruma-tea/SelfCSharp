using System;

namespace SelfCSharp.Chap07.Finalize;


public class MyProcess
{
    public MyProcess()
    {
        Console.WriteLine("constructor");
    }
    // ファイナライザー
    ~MyProcess()
    {
        Console.WriteLine("finalizer");
    }
}

public class FinalizeBasic
{
    static void Main(string[] args)
    {
        var mp = new MyProcess();
    }
}
