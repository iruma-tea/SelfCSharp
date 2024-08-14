using System;

namespace SelfCSharp.Chap08.ObjType;

public class Person
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public virtual string Show()
    {
        return $"名前は{this.LastName}{this.FirstName}です。";
    }
}

public class BusinessPerson : Person
{
    public override string Show()
    {
        return $"会社員の{this.LastName}{this.FirstName}です。";
    }

    public string Work()
    {
        return $"{this.LastName}{this.FirstName}は、働きます。";
    }
}

public class TypeGetBasic
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        Console.WriteLine(p1.GetType());
        Person p2 = new BusinessPerson();
        Console.WriteLine(p2.GetType());
    }
}
