using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class DeclareImplicitVar
    {
        public static void Test()
        {
            var a = 10;
            var b = "10";
            var c = true;
            Console.WriteLine(a.GetType().Name);
            Console.WriteLine(b.GetType().Name);
            Console.WriteLine(c.GetType());
            var test = new []{1, 2, 3};
           /* var test2 = new string[3][]{new []{"1", "2","3"}};
            Console.WriteLine(test.Rank);
            Console.WriteLine(test2.Rank);
            foreach (var i in test)
            {
                Console.WriteLine(i);
            }

            foreach (var t in test2)
            {
                foreach (var temp in t)
                {
                    Console.Write(temp + ", ");   
                }
            }
            */
        }
        
    }
}