using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Training
    {
        private static readonly FileReader ReadWaiterTraining = new FileReader(@"../../WaiterTraining.txt");
        private static readonly FileReader ReadHostTraining = new FileReader(@"../../HostTraining.txt");
        private static readonly FileReader ReadBartenderTraining = new FileReader(@"../../BartenderTraining.txt");
        private static readonly FileReader ReadDishwasherTraining = new FileReader(@"../../DishwasherTraining.txt");
        private static readonly FileReader ReadCookTraining = new FileReader(@"../../CookTraining.txt");
        private static readonly FileReader ReadBusserTraining = new FileReader(@"../../BusserTraining.txt");

        public static void DisplayWaiterTraining()
        {
            string training = ReadWaiterTraining.ReadStringFile();
            Console.WriteLine(training);
        }

        public static void DisplayHostTraining()
        {
            string training = ReadHostTraining.ReadStringFile();
            Console.WriteLine(training);
        }

        public static void DisplayBartenderTraining()
        {
            string training = ReadBartenderTraining.ReadStringFile();
            Console.WriteLine(training);
        }

        public static void DisplayDishwasherTraining()
        {
            string training = ReadDishwasherTraining.ReadStringFile();
            Console.WriteLine(training);
        }

        public static void DisplayCookTraining()
        {
            string training = ReadCookTraining.ReadStringFile();
            Console.WriteLine(training);
        }

        public static void DisplayBussserTraining()
        {
            string training = ReadBusserTraining.ReadStringFile();
            Console.WriteLine(training);
        }
    }
}
