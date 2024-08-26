using System;

namespace SelfCSharp.Chap09.ObjectEquals2;

public class Person : IEquatable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public bool Equals(Person? other)
    {
        if (Object.ReferenceEquals(this, other))
        {
            return true;
        }

        if (other == null || this.GetType() != other.GetType())
        {
            return false;
        }

        return this.FirstName == other.FirstName && this.LastName == other.LastName;
    }

    public override bool Equals(object? obj)
    {

        return this.Equals(obj as Person);
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
    }
}


public class ObjEqualsSafe
{
    static void Main(string[] args)
    {
        var p = new Person("掛谷", "哲夫");
        Console.WriteLine(p.GetHashCode());
        var d = new Dictionary<Person, int>();
        d.Add(p, 10);
        p.LastName = "山田";
        Console.WriteLine(p.GetHashCode());
        Console.WriteLine(d[p]);
    }

}
