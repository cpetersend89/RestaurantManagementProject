using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Tools
    {
        public static int VerifyNumber()
        {
            int number;
            string userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out number))
            {
                Console.WriteLine("Invalid: Not a number, enter a valid number");
                userInput = Console.ReadLine();
            }
            return number;
        }
        public static void PrintList<T>(List<T> list)
        {
            foreach (T obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        public static void ClearConsole()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static DateTime SetMonthDayYearHourMinute()
        {
            Console.Write("Input Month 1 - 12: ");
            int month = VerifyNumber();
            Console.Write("Input day: ");
            int day = VerifyNumber();
            Console.Write("Input Year: ");
            int year = VerifyNumber();
            Console.Write("Input Hour: ");
            int hour = VerifyNumber();
            Console.Write("Input Minute: ");
            return new DateTime(year, month, day);
        }
    }
}
