using System;

namespace SelfCSharp.Chap09.Struct;

struct Coordinate
{
    public double Latitude;
    public double Longitude;

    public Coordinate(double Latitude, double Longitude)
    {
        this.Latitude = Latitude;
        this.Longitude = Longitude;
    }

    public override string ToString()
    {
        return $"緯度：{this.Latitude}／緯度：{this.Longitude}";
    }
}

public class StructConstructor
{
    static void Main(string[] args)
    {
        var c = new Coordinate(35.681167, 139.767052);
        Console.WriteLine(c);
    }
}
