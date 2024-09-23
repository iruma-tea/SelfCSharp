using System;

namespace SelfCSharp.Chap10;

public class LambdaCapture
{
    // ラムダ式を返す静的メソッド
    static Action CreateAction(int init)
    {
        int value = init;
        return () =>
        {
            value++;
            Console.WriteLine(value);
        };
    }

    static void Main(string[] args)
    {
        // ラムダ式を生成
        var show = CreateAction(10);
        show();
        show();
    }
}
