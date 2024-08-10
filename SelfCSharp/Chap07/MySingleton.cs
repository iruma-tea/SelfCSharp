using System;

namespace SelfCSharp.Chap07;

public class MySingleton
{
    private static MySingleton instance = new MySingleton();

    private MySingleton()
    {

    }

    public static MySingleton Instance
    {
        get
        {
            return instance;
        }
    }
}
