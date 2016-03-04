using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }

        public Employee(int employeeId, string firstName, string lastName, string phoneNumber, string position)
        {
            EmployeeId = employeeId;
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
            PhoneNumber = phoneNumber.Trim();
            Position = position.Trim();
        }

        public override string ToString()
        {
            return $"{EmployeeId}, {FirstName}, {LastName}, {PhoneNumber} {Position}";
        }
    }
}
