using System;

namespace SelfCSharp.Chap07.Practice;

public class PClass
{
    int data = 10;

    void Hoge(int data)
    {
        if (data < 0)
        {
            data = 0;
        }
        Console.WriteLine(data);
    }
}
