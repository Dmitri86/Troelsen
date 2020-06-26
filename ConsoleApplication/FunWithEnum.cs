using System;

namespace ConsoleApplication
{
    public class FunWithEnum
    {
        public static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manger:
                    Console.WriteLine("1");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("2");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("3");
                    break;
                case EmpType.VisePresident:
                    Console.WriteLine("4");
                    break;
            }
        }
        
    }

    public enum EmpType
    {
        Manger = 102, 
        Grunt, 
        Contractor,
        VisePresident
    }
}