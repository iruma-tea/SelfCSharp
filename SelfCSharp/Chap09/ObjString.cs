using System;

namespace SelfCSharp.Chap09.ObjectBasic;

public class Person
{

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string LastName)
    {
        this.FirstName = firstName;
        this.LastName = LastName;
    }

    public override string ToString()
    {
        return $"Prson: {this.LastName} {this.FirstName}";
    }

}

public class ObjString
{
    static void Main(string[] args)
    {
        var p = new Person("太郎", "山田");
        Console.WriteLine(p.ToString());
    }
}
