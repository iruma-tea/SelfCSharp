using System;

namespace SelfCSharp.Chap11;

public class ThreadClassic
{
    static void Main(string[] args)
    {
        // スレッドを生成
        var t1 = new Thread(Count);
        var t2 = new Thread(Count);
        var t3 = new Thread(Count);

        t1.Start(1);
        t2.Start(2);
        t3.Start(3);

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("すべての処理が終了しました。");
    }

    static void Count(object? n)
    {
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine($"Thread{n}: {i}");
        }
    }
}
