using System;

namespace SelfCSharp.Chap09;

struct Coordinate
{
    public double Latitude;
    public double Longitude;

    public override string ToString()
    {
        return $"緯度: {this.Latitude}／経度：{this.Longitude}";
    }
}

public class StructBasic
{
    static void Main(string[] args)
    {
        var c = new Coordinate();
        c.Latitude = 35.681167;
        c.Longitude = 139.767052;
        Console.WriteLine(c);

        //var c = new Coordinates
        //{
        //    Latitude = 35.681167,
        //    Longitude = 139.767052
        //};

        ////var c = default(Coordinates);
        //Console.WriteLine(c);

        //Console.WriteLine(c.Longitude);

        //Coordinates c;
        //Console.WriteLine(c.Longitude);

    }
}
