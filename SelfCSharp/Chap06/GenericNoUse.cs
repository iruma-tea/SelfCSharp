﻿using System.Collections;

namespace SelfCSharp.Chap06;

public class GenericNoUse
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add("あいうえお");
        list.Add("かきくけこ");
        string str = (string)list[0];

        Console.WriteLine(str);
    }
}
