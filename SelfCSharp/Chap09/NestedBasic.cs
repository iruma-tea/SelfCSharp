using System;

namespace SelfCSharp.Chap09.Nested;

public class MyClass
{
    class MyHelper
    {
        public void Show()
        {
            Console.WriteLine("Nested Class is running!");
        }
    }

    public void Run()
    {
        var helper = new MyHelper();
        helper.Show();
    }
}
public class NestedBasic
{
    static void Main(string[] args)
    {
        var c = new MyClass();
        c.Run();

        // var h = new MyClass.MyHelper(); // 結果エラー
    }
}
