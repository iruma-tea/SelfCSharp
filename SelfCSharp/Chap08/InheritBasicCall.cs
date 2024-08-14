using System;

namespace SelfCSharp.Chap08.Prop;

public class EliteBusinessPerson : BusinessPerson
{
    public new String Work()
    {
        var result = base.Work();
        return $"{result} いつもテキパキと";
    }
}

public class InheritBasicCall
{
    static void Main(string[] args)
    {
        var ep = new EliteBusinessPerson
        {
            FirstName = "太郎",
            LastName = "山田"
        };
        Console.WriteLine(ep.Work());
    }
}
