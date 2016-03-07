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
        public void DisplayMainMenu()
        {
            Console.WriteLine("Main Menu:\n(1) Add Employee\n(2) Create Daily Schedule\n(3) Queries\n(4) Lunch/Dinner Menu\n(5) Training\n(6) Employee Hireability Questionnaire\n(7) Customer Reservations\n(8) Terminate Employee\n(9) Close Application");
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
                    case 5: //Training Menu
                        Console.Clear();
                        DisplayTrainingMenu();
                        break;
                    case 6:
                        Console.Clear();
                        bool hireable = Employee.CheckIfHireable();
                        Console.WriteLine($"\nHireable: {hireable}");
                        Tools.ClearConsole();
                        break;
                    case 7:
                        Console.Clear();
                        DisplayReservationMenu();
                        break;
                    case 8: //Terminate Employee
                        Query.TerminateEmployee();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: Please choose a valid option");
                        break;
                }
                DisplayMainMenu();
            }
        }

        private void DisplayQueriesMenu()
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

        private void DisplayDailyScheduleMenu()
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
                    case 4: //Main Menu
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

        private void DisplayTrainingMenu()
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
                    case 5: //Cook Training
                        Console.Clear();
                        Training.DisplayCookTraining();
                        Tools.ClearConsole();
                        break;
                    case 6: //Dishwasher Training
                        Console.Clear();
                        Training.DisplayDishwasherTraining();
                        Tools.ClearConsole();
                        break;
                    case 7: //Main Menu
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

        private void DisplayReservationMenu()
        {
            Console.WriteLine("Reservations:\n(1) Set Available Times for the Day\n(2) View Available Times\n(3) View Reservations\n(4) Make Reservation\n(5) Main Menu");
            while (true)
            {
                int choice = Tools.VerifyNumber();
                switch (choice)
                {
                    case 1: //Set Available Reservation Times
                        Console.Clear();
                        Reservation.SetDailyReservationTimes();
                        Tools.ClearConsole();
                        break;
                    case 2: //View Available Times
                        Console.Clear();
                        Reservation.ViewAvailiableReservations();
                        Tools.ClearConsole();
                        break;
                    case 3: //View Reservations
                        Console.Clear();
                        Reservation.ViewReservations();
                        Tools.ClearConsole();
                        break;
                    case 4: //Make Reservation
                        Console.Clear();
                        Reservation.SetReservation();
                        Tools.ClearConsole();
                        break;
                    case 5: //Main Menu
                        Console.Clear();
                        DisplayMainMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: Please choose a valid option");
                        break;
                }
                DisplayReservationMenu();
            }
        }
    }
}
