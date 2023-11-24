namespace SelfCSharp.Chap04
{
    internal class PreIf
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.WriteLine("デバック時にだけ表示します。");
#endif
        }
    }
}