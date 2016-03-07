using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        private static readonly FileWriter FileWriter = new FileWriter(@"../../Employees.txt");

        public Employee(int employeeId, string firstName, string lastName, string phoneNumber, string position)
        {
            EmployeeId = employeeId;
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
            PhoneNumber = phoneNumber.Trim();
            Position = position.Trim();
        }

        public static void AddEmployee()
        {
            Employee employee = UserInput.GetEmployeeInfo();
            FileWriter.WriteEmployeeFile(employee);
        }

        private static int GetQuestionnaireTotal()
        {
            Console.WriteLine("Rate potential employee on a scale of 1 - 10");
            Console.Write("Customer service skills: ");
            int customerService = Tools.VerifyNumber();
            Console.Write("Approachability/Friendliness: ");
            int friendliness = Tools.VerifyNumber();
            Console.Write("Technical skills: ");
            int technical = Tools.VerifyNumber();
            Console.Write("Product knowledge: ");
            int product = Tools.VerifyNumber();
            Console.Write("Experience: ");
            int experience = Tools.VerifyNumber();
            Console.Write("Availability: ");
            int availibility = Tools.VerifyNumber();
            int totalRating = customerService + friendliness + technical + product + experience + availibility;
            return totalRating;
        }

        public static int Average(int total, int numOfQuestions)
        {
            return total/numOfQuestions;
        }

        public static bool CheckIfHireable()
        {
            int questionnaireTotal = GetQuestionnaireTotal();
            int numOfQuestions = 6;
            int rating = Average(questionnaireTotal, numOfQuestions);
            if (rating >= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{EmployeeId}, {FirstName}, {LastName}, {PhoneNumber}, {Position}";
        }
    }
}
