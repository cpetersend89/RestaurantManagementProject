using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Query
    {
        private static readonly FileReader FileReader = new FileReader(@"../../Employees.txt");
        private static readonly FileWriter FileWriter = new FileWriter(@"../../Employees.txt");
        private static readonly FileReader FileReader2 = new FileReader(@"../../DailySchedule.txt");

        public static void ViewAllEmployees()
        {
            List<Employee> employees = FileReader.ReadEmployeeFile();
            Tools.PrintList(employees);
        }

        public static List<Employee> GetAllEmployeeList()
        {
            List<Employee> employees = FileReader.ReadEmployeeFile();
            return employees;
        }

        public static void ViewDailySchedule()
        {
            List<Employee> employees = FileReader2.ReadEmployeeFile();
            Tools.PrintList(employees);
        }
        public static void FindEmployeesByPosition(string position)
        {
            List<Employee> temp = FileReader.ReadEmployeeFile();
            List<Employee> employees = temp.FindAll(x => x.Position == position);
            Tools.PrintList(employees);
        }

        public static void FindEmployeeById(int employeeId)
        {
            List<Employee> temp = FileReader.ReadEmployeeFile();
            Employee employee = temp.Find(x => x.EmployeeId == employeeId);
            Console.WriteLine(employee);
        }

        public static Employee GetEmployeeById(int employeeId)
        {
            List<Employee> temp = FileReader.ReadEmployeeFile();
            Employee employee = temp.Find(x => x.EmployeeId == employeeId);
            return employee;
        }

        public static void TerminateEmployee()
        {
            while (true)
            {
                Console.Clear();
                List<Employee> employees = FileReader.ReadEmployeeFile();
                Tools.PrintList(employees);
                int employeeId = UserInput.GetEmployeeIdNumber();
                Employee employee = GetEmployeeById(employeeId);
                Console.WriteLine($"\nConfirmation: {employee}");
                Console.WriteLine("(1) Submit (2) Cancel");
                int choice = Tools.VerifyNumber();
                if (choice == 1)
                {
                    employees.RemoveAll(x => x.EmployeeId == employeeId);
                    FileWriter.OverrideListToFile(employees);
                }
                if (choice == 2)
                {
                    continue;
                }
                break;
            }
        }
    }
}

