using System;

namespace SelfCSharp.Chap09;

public enum Season
{
    Spring,
    Summer,
    Auturm,
    Winter,
}

public class SeasonEnum
{
    public void ProcessSeason(Season season)
    {
        Console.WriteLine(season);
    }
}

public class SeasonEnumClient
{
    static void Main(string[] args)
    {
        var se = new SeasonEnum();
        se.ProcessSeason(Season.Spring);
    }
}

