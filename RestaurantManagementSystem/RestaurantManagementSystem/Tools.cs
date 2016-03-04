using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Tools
    {
        
        public static void PrintObjectList<T>(List<T> objects)
        {
            foreach (T obj in objects)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
