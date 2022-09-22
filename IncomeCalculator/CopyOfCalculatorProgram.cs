using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeCalculator
{
    internal class Program
    {
        public static  UserInfo person = new UserInfo();
        public static List<TimeSheet> timeSheets = new List<TimeSheet>();
        public static JuniorEmployee employee = new JuniorEmployee();
        public static SeniorEmployee seniorEmployee = new SeniorEmployee();


        static void Main(string[] args)
        {
            Console.Title = "First Project: Income Calculator ";

            #region VariableDeclaration
            string firstName = "";
            string lastName = "";
            string idBadge = "";
            int companyTotal = 0;
            int appleTotal = 0;
            int samsungTotal = 0;
            string answer = "";
            #endregion

            Messages.WelcomeMessage();

            #region UserInfoRequest

            Messages.RequestInfoUser("Enter your first name: ");
            firstName = Console.ReadLine();
            person.FirstName = firstName;
            Messages.RequestInfoUser("Enter your last name: ");
            lastName = Console.ReadLine();
            person.LastName = lastName;
            Messages.RequestInfoUser("Enter your badge Id KeyLevel(JD***/SD***): ");
            idBadge = Console.ReadLine();
            person.IdBadge = idBadge;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(person.FullName);
            Console.ResetColor();
            Console.WriteLine();
            #endregion

            #region WorkInfoRequest
            do
            {
                var time = new TimeSheet();
                Messages.RequestInfoUser("Enter company that you work for: ");
                string companyName = Console.ReadLine();
                Messages.RequestInfoUser("How many hours do you work for them: ");
                int hoursWork = Convert.ToInt32(Console.ReadLine());
                time.CompanyName = companyName;
                time.HoursWork = hoursWork;
                timeSheets.Add(time);

                Messages.RequestInfoUser("Do you want to add more[Yes/No]: ");
                answer = Console.ReadLine();
               

            } while (answer.ToLower() == "yes");
            #endregion

            #region CalculatingCompanyBill:Apple

            for (int i = 0; i < timeSheets.Count; i++)
            {
                if (timeSheets[i].CompanyName.ToLower().Contains("apple"))
                {
                    companyTotal += RequestTimeSheetUser.AppleTimeSheetCalculator(timeSheets[i].HoursWork);
                }
            }
            if (companyTotal > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Simulating Sending an email to Apple...");
                Console.WriteLine($"Your bill is {companyTotal} for the {companyTotal / 150} hours worked.\n");
                Console.ResetColor();
                appleTotal = companyTotal;
            }
            companyTotal = 0;
            #endregion

            #region CalculatingCompanyBill:Samsung

            for (int i = 0; i < timeSheets.Count; i++)
            {
                if (timeSheets[i].CompanyName.ToLower().Contains("samsung"))
                {
                    companyTotal += RequestTimeSheetUser.SamsungTimeSheetCalculator(timeSheets[i].HoursWork);
                }
            }
            if (companyTotal > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Simulating Sending an email to Samsung...");
                Console.WriteLine($"Your bill is {companyTotal} for the {companyTotal / 125} hours worked.\n");
                Console.ResetColor();
               samsungTotal = companyTotal;
            }
            companyTotal = 0;
            #endregion

            #region CalculatingUserPayment
            if (idBadge.ToLower().Contains("jd"))
            {
                employee.JuniorStandardPayment((appleTotal / 150) + (samsungTotal / 125));
            }
            else if (idBadge.ToLower().Contains("sd"))
            {
                seniorEmployee.SeniorStandardPayment((appleTotal / 150) + (samsungTotal / 125));
            }
            #endregion
            Console.ReadKey();
        }
    }
}
