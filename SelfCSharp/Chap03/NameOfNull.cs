namespace SelfCSharp.Chap03;

public class NameOfNull
{
    public void Hoge(string? str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }
        Console.WriteLine(str);
    }

    static void Main(string[] args)
    {
        var nc = new NameOfNull();
        nc.Hoge(null);
    }
}
