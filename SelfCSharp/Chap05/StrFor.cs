namespace SelfCSharp.Chap05
{
    internal class StrFor
    {
        static void Main(string[] args)
        {
            var str = "ウィングス";
            foreach (var s in str)
            {
                Console.WriteLine(s);
            }
        }
    }
}