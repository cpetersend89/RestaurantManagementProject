using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();
            Employee employee = ui.AddEmployee();
            Console.WriteLine(employee);

            Console.ReadKey();

        }
    }
}
