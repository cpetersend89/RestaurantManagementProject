using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class DailySchedule
    {
        static readonly FileWriter WriteScheduleToFile = new FileWriter(@"../../DailySchedule.txt");
        static readonly FileReader ReadSchedule = new FileReader(@"../../DailySchedule.txt");
        static readonly List<Employee> Employees = new List<Employee>(); 
        public static void MakeDailySchedule()
        {
            Console.WriteLine("Add employee to schedule? (1) Yes (2) No");
            int choice = Tools.VerifyNumber();
            while (choice == 1)
            {
                Console.Clear();
                Query.ViewAllEmployees();
                Console.Write("\nEnter employee ID to schedule: ");
                int employeeId = Tools.VerifyNumber();
                List<Employee> temp = Query.GetAllEmployeeList();
                Employee employee = temp.Find(x => x.EmployeeId == employeeId);
                Employees.Add(employee);
                Tools.PrintList(Employees);
                Console.WriteLine("Add another employee? (1) Yes (2) No");
                choice = Tools.VerifyNumber();
            }
        }

        public static void PrintScheduleToFile()
        {
            WriteScheduleToFile.OverrideListToFile(Employees);
            string schedule = ReadSchedule.ReadStringFile();
            Console.WriteLine(schedule);
        }
    }
}
