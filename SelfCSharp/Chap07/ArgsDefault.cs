using System;

namespace SelfCSharp.Chap07.MethodArgs;

public class Person
{
    public string firstName = "";
    public string lastName = "";

    public void Show(string greeting = "こんにちは", string title = "さん")
    {
        Console.WriteLine($"{greeting}、{this.lastName}{this.firstName}{title}!");
    }
}

public class ArgsDefault
{
    static void Main(string[] args)
    {
        var p = new Person()
        {
            lastName = "山田",
            firstName = "太郎"
        };
        p.Show();
        p.Show("はじめして");
    }
}
