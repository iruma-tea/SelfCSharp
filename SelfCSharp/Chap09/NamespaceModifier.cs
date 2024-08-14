using System.Globalization;
using Chapter = SelfCSharp.Chap09.Other;

namespace SelfCSharp.Chap09.Ns;

public class NamespaceModifier
{
    static void Main(string[] args)
    {
        //var ci = new Chapter.CultureInfo("ja-JP");
        var ci = new Chapter::CultureInfo("ja-JP");
    }

}

public class Chapter { }
