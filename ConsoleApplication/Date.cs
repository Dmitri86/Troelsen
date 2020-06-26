using System;

namespace ConsoleApplication
{
    public class Date
    {
        public static void test()
        {
            var a = new DateTime(2016, 10, 17);
            Console.WriteLine(a);
            Console.WriteLine(a.Hour);
            Console.WriteLine(a.Ticks);
            Console.WriteLine(a.DayOfWeek);
            Console.WriteLine(a.DayOfYear);
            var b = DateTime.Now;
            Console.WriteLine(b);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(b.ToLocalTime());
            Console.WriteLine(b.ToUniversalTime());
            var c = new TimeSpan(4, 30, 0);
            Console.WriteLine(c.TotalSeconds);
            Console.WriteLine(TimeSpan.TicksPerHour);
        }
    }
}