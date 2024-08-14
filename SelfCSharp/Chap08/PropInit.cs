using System;

namespace SelfCSharp.Chap08;

public class Pet
{
    public string Name { get; init; }

    public Pet(string name = "")
    {
        this.Name = name;
    }
}
public class PropInit
{
    static void Main(string[] args)
    {
        var p1 = new Pet("のどか");

        var p2 = new Pet
        {
            Name = "まめ"
        };

        Console.WriteLine(p2.Name);
    }
}
