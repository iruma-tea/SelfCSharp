namespace SelfCSharp.Chap05
{
    internal class StrAny
    {
        static void Main(string[] args)
        {
            var str = "ＷＩＮＧＳ２号";
            Console.WriteLine(str.Any(ch => Char.IsDigit(ch)));
        }
    }
}