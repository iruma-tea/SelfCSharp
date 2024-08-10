using System;

namespace SelfCSharp.Chap07;

public class MethodLocalStatic
{
    int myfield = 0;
    static int myfield2 = 0;

    static void Main(string[] args)
    {
        var mylocal = 1;
        const int MY_CONST = 2;

        static void Hoge()
        {
            Console.WriteLine(myfield2);
            Console.WriteLine(MY_CONST);
            Console.WriteLine(nameof(mylocal));
        }
        Hoge();
    }
}
