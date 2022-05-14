using System;

namespace IncomeCalculator
{
    public class SeniorEmployee
    {
        public int SeniorStandardPayment(int hourWork)
        {
            int seniorTotalPayment = hourWork * 20;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You will get paid as a senior developer £{seniorTotalPayment} for your time.");
            Console.ResetColor();
            return seniorTotalPayment;
            
        }
    }
}
