using System;

namespace SelfCSharp.Chap09;

public partial class MyPartialMethod
{
    static partial void Log()
    {
        Console.WriteLine("ログを記録しました。");
    }
}
