using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class FoodMenu
    {
        public string Meal { get; set; }
        public decimal Price { get; set; }
        private static readonly FileReader FileReader = new FileReader(@"../../RestaurantMenu.txt");

        public FoodMenu(string meal, decimal price)
        {
            Meal = meal;
            Price = price;
        }

        public static void ViewMenu()
        {
            string menu = FileReader.ReadStringFile();
            Console.WriteLine(menu);
        }

        public override string ToString()
        {
            return $"{Meal}, {Price}";
        }
    }
}
