using System;

namespace SelfCSharp.Chap08.Cast;

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
    public string Work()
    {
        return $"会社員の{this.LastName}{this.FirstName}です。";
    }
}

public class CastUp
{
    static void Main(string[] args)
    {
        Person bp = new BusinessPerson
        {
            FirstName = "太郎",
            LastName = "山田"
        };
        Console.WriteLine(bp.Show());
    }
}
