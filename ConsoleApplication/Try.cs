using System;

namespace ConsoleApplication
{
    public class Try
    {
        public static void TryPar()
        {
            var a = int.TryParse("10", out var b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            var c = int.TryParse("dg", out b);
            Console.WriteLine(c);
            Console.WriteLine(b);
        }
    }
}