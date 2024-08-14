using System;

namespace SelfCSharp.Chap09.Priority1
{

    public class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("Priority1名前空間");
        }
    }

}

namespace SelfCSharp.Chap09.Priority2
{
    public class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("Priority2名前空間");
        }
    }
}

namespace SelfCSharp.Chap09.Priority3
{
    public class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("Priority3名前空間");
        }
    }
}

// public class MyUtil {
//     public void static Run() {
//         Console.WriteLine("グローバル名前空間");
//     }
// }

namespace SelfCSharp.Chap09.Priority
{
    using SelfCSharp.Chap09.Priority3;

    public class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("現在の名前空間");
        }
    }

    public class NamespacePriority
    {
        static void Main(string[] args)
        {
            MyUtil.Run();
        }
    }
}