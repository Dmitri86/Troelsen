using System;

namespace ConsoleApplication
{
    public class Strings
    {
        public static void Test()
        {
            Console.WriteLine(@"lala/'/dasfjklsdf");
            var str = @"This is a very
                very
                    very
                        long string";
            Console.WriteLine(str);
        }
    }
}