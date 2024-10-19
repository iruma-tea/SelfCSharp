using System;
using System.Dynamic;

namespace SelfCSharp.Chap11;

public class ExpandoBasic
{
    static void Main(string[] args)
    {
        dynamic e = new ExpandoObject();
        e.Count = 1;
        e.Name = "山田";
        Console.WriteLine(e.Count);
        Console.WriteLine(e.Name);
    }
}
