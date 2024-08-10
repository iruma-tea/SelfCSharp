using System;

namespace SelfCSharp.Chap07.ClassConst;


public class Person
{
    public string firstName;
    public string lastName;

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string Show()
    {
        return $"名前は{this.lastName}{this.firstName}です。";
    }
}
public class ConstBasic
{
    static void Main(string[] args)
    {
        var p = new Person("太郎", "山田");
        Console.WriteLine(p.Show());
    }
}
