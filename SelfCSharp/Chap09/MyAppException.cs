using System.Runtime.Serialization;

namespace SelfCSharp.Chap09;

public class MyAppException : Exception
{
    public MyAppException()
    {

    }

    public MyAppException(string message) : base(message) { }

    public MyAppException(SerializationInfo info, StreamingContext context) : base(info, context) { }

}

public class MyAppExceptionClient
{
    static void Main(string[] args)
    {
        throw new MyAppException("例外発生！");
    }
}