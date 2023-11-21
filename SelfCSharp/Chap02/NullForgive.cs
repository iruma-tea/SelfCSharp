namespace SelfCSharp.Chap02
{
    internal class NullForgive
    {
        static void Main(string[] args)
        {
            string?[] format = { "2022-12-25 10:16:23" };
            var dt = DateTime.Parse(format[0]!);
            Console.WriteLine(dt);
        }
    }
}
