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

        public void CheckIfHirable()
        {
            Console.WriteLine("Rate potential employee on a scale of 1 - 10");

        }

        public override string ToString()
        {
            return $"{EmployeeId}, {FirstName}, {LastName}, {PhoneNumber}, {Position}";
        }
    }
}
