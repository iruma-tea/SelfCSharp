using System;

namespace SelfCSharp.Chap07.Construct;

public class Message
{
    int number;

    static Message()
    {
        Console.WriteLine("静的コンストラクタ―");
    }

    public Message(int number)
    {
        this.number = number;
        Console.WriteLine($"通常のコンストラクタ―{number}");
    }
}

public class ConstructorStatic
{
    static void Main(string[] args)
    {
        var m1 = new Message(1);
        var m2 = new Message(2);
    }
}
