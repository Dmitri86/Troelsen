using System;

namespace ConsoleApplication
{
    public class ExplicitCast
    {
        public static void Test()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                byte sum = checked((byte) (b1 + b2));
                Console.WriteLine($"Sum = {sum}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}