using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class UserInput
    {
        public Employee AddEmployee()
        {
            int employeeId = GetEmployeeIdNumber();
            string firstName = GetEmployeeFirstName();
            string lastName = GetEmployeeLastName();
            string phoneNumber = GetEmployeePhoneNumber();
            string position = GetEmployeePosition();
            return new Employee(employeeId, firstName, lastName, phoneNumber, position);
        }

        public static int GetEmployeeIdNumber()
        {
            Console.Write("Assign employee an ID number: ");
            int idNumber = Tools.VerifyNumber();
            return idNumber;
        }
        public static string GetEmployeeFirstName()
        {
            Console.Write("Enter employee first name: ");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public static string GetEmployeeLastName()
        {
            Console.Write("Enter employee last name: ");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string GetEmployeePhoneNumber()
        {
            Console.Write("Enter employee phone number: ");
            string phoneNumber = Console.ReadLine();
            return phoneNumber;
        }

        public static string GetEmployeePosition()
        {
            Console.WriteLine("Select employee position:");
            Postions.ViewPositions();
            int choice = Tools.VerifyNumber();
            while (true)
            {
                switch (choice)
                {
                    case 1:
                        return "WAITER";
                    case 2:
                        return "HOST";
                    case 3:
                        return "BUSSER";
                    case 4:
                        return "BARTENDER";
                    case 5:
                        return "COOK";
                    case 6:
                        return "DISH WASHER";
                    default:
                        Console.WriteLine("Invalid: Select (1) Waiter (2) Host (3) Busser (4) Bartender (5) Cook (6) Dish Washer");
                        choice = Tools.VerifyNumber();
                        break;
                }
            }
        }
    }
}
