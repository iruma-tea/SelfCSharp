using System;

namespace SelfCSharp.Chap08.Practice;

public interface IAnimal
{
    string Name { get; set; }
    void Move();
}

public class Hamster : IAnimal
{
    public string Name { get; set; } = "";

    public void Move()
    {
        Console.WriteLine($"{this.Name}は、トコトコ歩きます。");
    }
}

public class Practice5
{
    static void Main(string[] args)
    {
        IAnimal i = new Hamster()
        {
            Name = "サクラ"
        };
        i.Move();
    }
}
