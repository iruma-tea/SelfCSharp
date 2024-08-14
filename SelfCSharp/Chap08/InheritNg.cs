using System;

namespace SelfCSharp.Chap08.Inherit;

public sealed class Person
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public string Show()
    {
        return $"名前は{this.LastName}{this.FirstName}です。";
    }
}

// public class BusinessPerson : Person { }

public class InheritNg
{
    static void Main(string[] args)
    {
        // var c = new BusinessPerson();
    }
}
