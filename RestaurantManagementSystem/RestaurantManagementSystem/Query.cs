using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Query
    {
        private static readonly FileReader FileReader = new FileReader(@"../../Employees.csv");
        private static readonly FileWriter FileWriter = new FileWriter(@"../../Employees.csv");

        public static void ViewAllEmployees()
        {
            List<Employee> employees = FileReader.ReadEmployeeFile();
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

        public static void TerminateEmployee(int employeeId)
        {
            List<Employee> employees = FileReader.ReadEmployeeFile();
            while (true)
            {
                Employee employee = GetEmployeeById(employeeId);
                if (employees.Contains(employee))
                {
                    employees.Remove(employee);
                }
                else
                {
                    Console.WriteLine("Invalid: employee does not exist");
                }
                FileWriter.OverrideEmployeeFile(employees);
                break;
            }
            
        }
    }
}
