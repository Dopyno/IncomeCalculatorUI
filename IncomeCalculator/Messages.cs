using System;

namespace IncomeCalculator
{
    public class Messages
    {
        public static void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("   Welcome to our website to register your work and calculate your income!");
            Console.WriteLine("*******************************************************************************");
            Console.ResetColor();
            Console.WriteLine();
        }
        public static void RequestInfoUser(string message)
        {
            Console.WriteLine(message);
        }
    }
}
