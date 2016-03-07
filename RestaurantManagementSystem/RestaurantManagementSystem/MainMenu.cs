using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class MainMenu
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine("Main Menu:\n(1) Add Employee\n(2) Create Daily Schedule\n(3) Queries\n(4) Lunch/Dinner Menu\n(5) Training\n(6) Terminate Employee");
            while (true)
            {
                int choice = Tools.VerifyNumber();
                switch (choice)
                {
                    case 1: //Add Employee
                        Console.Clear();
                        Employee.AddEmployee();
                        Tools.ClearConsole();
                        break;
                    case 2: //Create Daily Schedule
                        Console.Clear();
                        DisplayDailyScheduleMenu();
                        break;
                    case 3: //Queries
                        Console.Clear();
                        DisplayQueriesMenu();
                        break;
                    case 4: //View Food Menu
                        Console.Clear();
                        FoodMenu.ViewMenu();
                        Tools.ClearConsole();
                        break;
                    case 5:
                        Console.Clear();
                        DisplayTrainingMenu();
                        break;
                    case 6: //Terminate Employee
                        Query.TerminateEmployee();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: Please choose a valid option");
                        break;
                }
                DisplayMainMenu();
            }
        }

        public static void DisplayQueriesMenu()
        {
            Console.WriteLine("Queries Menu:\n(1) View All Employees\n(2) View Employees by Position\n(3) View Employee by ID\n(4) Main Menu");
            while (true)
            {
                
                int choice = Tools.VerifyNumber();
                switch (choice)
                {
                    case 1: //View All Employees
                        Console.Clear();
                        Query.ViewAllEmployees();
                        Tools.ClearConsole();
                        break;
                    case 2: //View Employees by Position
                        Console.Clear();
                        string position = UserInput.GetEmployeePosition();
                        Query.FindEmployeesByPosition(position);
                        Tools.ClearConsole();
                        break;
                    case 3: //View Employee by ID
                        Console.Clear();
                        int employeeId = UserInput.GetEmployeeIdNumber();
                        Query.FindEmployeeById(employeeId);
                        Tools.ClearConsole();
                        break;
                    case 4: //Main Menu
                        Console.Clear();
                        DisplayMainMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: Please choose a valid option");
                        break;
                }
                DisplayQueriesMenu();
            }
        }

        public static void DisplayDailyScheduleMenu()
        {
            Console.WriteLine("Daily Schedule:\n(1) Add Employee\n(2) Submit Schedule\n(3) View Schedule\n(4) Main Menu");
            while (true)
            {
                int choice = Tools.VerifyNumber();
                switch (choice)
                {
                    case 1: //Add Employee
                        Console.Clear();
                        DailySchedule.MakeDailySchedule();
                        Tools.ClearConsole();;
                        break;
                    case 2: //Submit Schedule
                        Console.Clear();
                        DailySchedule.PrintScheduleToFile();
                        Tools.ClearConsole();
                        break;
                    case 3: //View Schedule
                        Console.Clear();
                        Query.ViewDailySchedule();
                        Tools.ClearConsole();
                        break;
                    case 4:
                        Console.Clear();
                        DisplayMainMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: Please choose a valid option");
                        break;

                }
                DisplayDailyScheduleMenu();
            }
        }

        public static void DisplayTrainingMenu()
        {
            Console.WriteLine("Training:\n(1) Waiters\n(2) Bussers\n(3) Host\n(4) Bartender\n(5) Cook\n(6) Dishwasher\n(7) Main Menu");
            while (true)
            {
                int choice = Tools.VerifyNumber();
                switch (choice)
                {
                    case 1: //Waiters Training
                        Console.Clear();
                        Training.DisplayWaiterTraining();
                        Tools.ClearConsole();
                        break;
                    case 2: //Bussers Training
                        Console.Clear();
                        Training.DisplayBussserTraining();
                        Tools.ClearConsole();
                        break;
                    case 3: //Host Training
                        Console.Clear();
                        Training.DisplayHostTraining();
                        Tools.ClearConsole();
                        break;
                    case 4: //Bartender Training
                        Console.Clear();
                        Training.DisplayBartenderTraining();
                        Tools.ClearConsole();
                        break;
                    case 5:
                        Console.Clear();
                        Training.DisplayCookTraining();
                        Tools.ClearConsole();
                        break;
                    case 6:
                        Console.Clear();
                        Training.DisplayDishwasherTraining();
                        Tools.ClearConsole();
                        break;
                    case 7:
                        Console.Clear();
                        DisplayMainMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: Please choose a valid option");
                        break;
                }
                DisplayTrainingMenu();
            }
        }
    }
}
