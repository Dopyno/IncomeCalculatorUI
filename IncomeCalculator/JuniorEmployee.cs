using System;

namespace IncomeCalculator
{
    public class JuniorEmployee
    {
        public int JuniorStandardPayment(int hoursWorked)
        {
            int standardJuniorPayment = 10;
            int juniorTotalPayment = hoursWorked * standardJuniorPayment;
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"You will get paid as a junior developer £{juniorTotalPayment} for your time.");
            Console.ResetColor();
            return juniorTotalPayment;
           
        }
    }
}
