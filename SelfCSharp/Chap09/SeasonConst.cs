using System;

namespace SelfCSharp.Chap09.Const;

public class Season
{
    public const int Spring = 0;
    public const int Summer = 1;
    public const int Auturm = 2;
    public const int Winter = 3;

    public void ProcessSeason(int season)
    {
        Console.WriteLine(season);
    }
}

public class SeasonConst
{
    static void Main(string[] args)
    {
        var sc = new Season();
        sc.ProcessSeason(Season.Spring);
        sc.ProcessSeason(4);
    }
}
