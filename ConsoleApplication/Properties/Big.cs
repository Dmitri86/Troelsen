using System;

namespace ConsoleApplication.Properties
{
    public class Big
    {
        public static void test()
        {
            var a = System.Numerics.BigInteger.Parse("999999999999999999999999999999999999999999999999999");
            Console.WriteLine(a.IsEven);
            Console.WriteLine(a + 1);
        }
    }
}