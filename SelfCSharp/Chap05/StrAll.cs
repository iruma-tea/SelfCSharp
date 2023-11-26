namespace SelfCSharp.Chap05
{
    internal class StrAll
    {
        static void Main(string[] args)
        {
            var str = "ＷＩＮＧＳ２号";
            Console.WriteLine(str.All(ch => Char.IsDigit(ch)));
        }
    }
}