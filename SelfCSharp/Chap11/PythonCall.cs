using System;
using IronPython.Hosting;

namespace SelfCSharp.Chap11;

public class PythonCall
{
    static void Main(string[] args)
    {
        var py = Python.CreateRuntime();
        dynamic script = py.UseFile("Chap11/myClass.py");
        dynamic clazz = script.MyClass();
        Console.WriteLine(clazz.greet("山田"));
    }
}
