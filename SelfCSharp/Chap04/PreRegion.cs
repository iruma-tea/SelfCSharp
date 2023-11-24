namespace SelfCSharp.Chap04
{
    internal class PreRegion
    {
        static void Main(string[] args)
        {
            #region 定数／変数の定義
            const string Publisher = "翔泳社";
            const double Tax = 1.1;
            var author = "ＷＩＮＧＳプロジェクト";
            var title = "一人で学ぶ#C";
            var price = 1000;
            #endregion

            Console.WriteLine($"{title} ({Publisher}刊刊、{author}薯) 発売開始");
            Console.WriteLine($"{price * Tax}円");
        }
    }
}