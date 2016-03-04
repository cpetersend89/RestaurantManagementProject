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
    }
}
