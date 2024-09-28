using System;

namespace SelfCSharp.Chap11;

public class ThreadBasic
{
    static void Main(string[] args)
    {
        Task t1 = Task.Run(() => Count(1));
        Task t2 = Task.Run(() => Count(2));
        Task t3 = Task.Run(() => Count(3));

        t1.Wait();
        t2.Wait();
        t3.Wait();

        Console.WriteLine("すべての処理が終了しました。");

    }

    static void Count(int n)
    {
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine($"Thread{n}: {i}");
        }
    }
}
