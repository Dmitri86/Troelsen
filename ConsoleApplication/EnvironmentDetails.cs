using System;

namespace ConsoleApplication
{
    public class EnvironmentDetails
    {
        public static void ShowDetails()
        {
            foreach (var drive in System.Environment.GetLogicalDrives())
            {
                Console.WriteLine($"Drive: {drive}");
            }

            Console.WriteLine($"OS: {System.Environment.OSVersion}");
            Console.WriteLine($"Number of processors: {System.Environment.ProcessorCount}");
            Console.WriteLine($".Net Version: {System.Environment.Version}");
            Console.WriteLine($"MachineName: {System.Environment.MachineName}");
            Console.WriteLine($"New Line: {Environment.NewLine}");
            int my = default;
            Console.WriteLine(my);
            Console.WriteLine(bool.FalseString);
            Console.WriteLine(bool.TrueString);
            Console.WriteLine(123_155_678);
        }
    }
}