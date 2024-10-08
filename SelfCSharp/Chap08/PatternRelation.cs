using System;

namespace SelfCSharp.Chap08;

public class PatternRelation
{
    static void Main(string[] args)
    {
        var point = 45;

        Console.WriteLine(point switch
        {
            > 80 => "Excellent!!",
            > 60 => "Good!",
            > 40 => "Normal",
            _ => "Bad...",
        });
    }
}
