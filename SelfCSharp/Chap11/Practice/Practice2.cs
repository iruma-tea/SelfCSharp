using System;

namespace SelfCSharp.Chap11.Practice;

public class Practice2
{
    static void Main(string[] args)
    {
        Task<long> t = ProcessAsync();
        while (!t.IsCompleted)
        {
            t.Wait(100);
            Console.Write(".");
        }

    }
    static async Task<long> ProcessAsync()
    {
        return await Task.Run(() =>
        {
            var result = 0L;
            for (long i = 0; i <= 500000000; i++)
            {
                result += i;
            }
            return result;
        });
    }
}
