using System;

namespace SelfCSharp.Chap09;

public partial class MyPartialMethod
{
    static partial void Log();

    static void Main(string[] args)
    {
        Log();
    }
}
