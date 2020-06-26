using System;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var grunt = EmpType.Grunt;
            Console.WriteLine(grunt == EmpType.Grunt);
            FunWithEnum.AskForBonus(grunt);
            var vicePresident = EmpType.VisePresident;
            FunWithEnum.AskForBonus(vicePresident);
            Console.WriteLine((int) grunt);
            var enumData = Enum.GetValues(grunt.GetType());
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }
        }
    }
}