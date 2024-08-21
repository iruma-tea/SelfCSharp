using System;

namespace SelfCSharp.Chap09;

public class TryCatchOrder
{
    static void Main(string[] args)
    {
        try
        {
            using (var str = new StreamReader(@"C:\nothing.dat"))
            {
                Console.WriteLine(str.ReadToEnd());
            }
        }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.StackTrace);
        // }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
    }
}
