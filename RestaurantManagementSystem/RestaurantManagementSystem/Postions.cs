using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Postions
    {
        public static void ViewPositions()
        {
            List<string> positions = new List<string>();
            positions.Add("-----WAIT STAFF-----");
            positions.Add("(1) Waiter");
            positions.Add("(2) Host");
            positions.Add("(3) Busser");
            positions.Add("-----BAR STAFF-----");
            positions.Add("(4) Bartender");
            positions.Add("-----KITCHEN STAFF-----");
            positions.Add("(5) Cook");
            positions.Add("(6) Dishwasher");
            Tools.PrintList(positions);
        }
    }
}
