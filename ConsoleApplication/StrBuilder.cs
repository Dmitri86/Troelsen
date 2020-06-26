using System;
using System.Text;

namespace ConsoleApplication
{
    public class StrBuilder
    {
        public static void Test()
        {
            var sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
        }
    }
}