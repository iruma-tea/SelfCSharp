using System;

namespace SelfCSharp.Chap07;

public class MethodLocalShadow
{
    static void Main(string[] args)
    {
        var msg = "Local Variable";

        void MyLocal()
        {
            var msg = "Inner Variable";
            Console.WriteLine(msg);
        }
        MyLocal();
        Console.WriteLine(msg);
    }
}
