using SelfCSharp.Chap08.ExtensionBasic;

namespace SelfCSharp.Chap08.ExtensionUse;

public class ExtensionClient
{
    static void Main(string[] args)
    {
        var data = "ありがとう! ";
        Console.WriteLine(data.Repeat(3));
    }
}
