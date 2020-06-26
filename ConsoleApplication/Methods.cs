using System;

namespace ConsoleApplication
{
    public class Methods
    {
        public static void Test(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            var temp = s1;
            s1 = s2;
            s2 = temp;
        }

        public static ref string SampleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }

        public static double CalculateAverage(params double[] values)
        {
            Console.WriteLine($"You sent me {values.Length} doubles");
            var sum = 0.0D;
            if (values.Length == 0)
                return sum;
            foreach (var v in values)
            {
                sum += v;
            }

            return sum / values.Length;
        }

        public static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
            Console.BackgroundColor = oldBackgroundColor;
        }

        public static ref int Modified(int[] array)
        {
            return ref array[1];
        }

        public static void AddEvenNumbers(int a, int b, out int res)
        {
            if (IsEven(a) && IsEven(b))
            {
                res = a + b;
            }
            else
            {
                res = 0;
            }
            bool IsEven(int number)
            {
                return number % 2 == 0;
            }
        } 
    }
}