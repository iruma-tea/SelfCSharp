using System.Text;

namespace SelfCSharp.Chap05.Practice;

public class Practice3
{
    static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        using (var writer = new StreamWriter(@"/home/shusuke/work_csharp/SelfCSharp/Chap05/sample.dat", true,
            Encoding.GetEncoding("Shift-JIS")))
        {
            writer.WriteLine(string.Join(",", args));
        }

    }
}
