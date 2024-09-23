using System;

namespace SelfCSharp.Chap10;

public class LambdaAccess
{
    static void Main(string[] args)
    {
        var msg = "鈴木次郎";
        var show = () => { Console.WriteLine(msg); };
        show();
    }
}
