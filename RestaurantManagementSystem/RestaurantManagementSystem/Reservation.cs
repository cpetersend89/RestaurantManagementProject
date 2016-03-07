using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Reservation
    {
        private int _time;

        public Customer Customer { get; set; }

        static FileWriter writeReservationTimes = new FileWriter(@"../../ReservationTimes.txt");
        static FileWriter writeReservations = new FileWriter(@"../../CustomerReservations.txt");
        static FileReader readReservationTimes = new FileReader(@"../../ReservationTimes.txt");
        static FileReader readReservations = new FileReader(@"../../CustomerReservations.txt");

        public Reservation()
        {
            
        }

        public Reservation(int time, Customer customer)
        {
            _time = time;
            this.Customer = customer;
        }
        public static List<int> GetDailyReservationTimes()
        {
            List<int> reservationTimes = new List<int>();
            reservationTimes.Add(12);
            reservationTimes.Add(1);
            reservationTimes.Add(2);
            reservationTimes.Add(3);
            reservationTimes.Add(4);
            reservationTimes.Add(5);
            reservationTimes.Add(6);
            reservationTimes.Add(7);
            reservationTimes.Add(8);
            reservationTimes.Add(9);


            return reservationTimes;
        }

        public static void SetDailyReservationTimes()
        {
            List<int> reservationTimes = GetDailyReservationTimes();
            writeReservationTimes.OverrideListToFile(reservationTimes);
        }

        public static void ViewAvailiableReservations()
        {
            List<int> availableTime = readReservationTimes.ReadIntList();
            Tools.PrintList(availableTime);
        }

        private static int GetReservationTime(int setTime)
        {
            List<int> availableTimes = readReservationTimes.ReadIntList();
            return availableTimes.Find(x => x == setTime);
        }

        public static void SetReservation()
        {
            Console.WriteLine("Choose from an available time:");
            ViewAvailiableReservations();
            List<int> availableTimes = readReservationTimes.ReadIntList();
            int selectedTime = Tools.VerifyNumber();
            int timeFromList = GetReservationTime(selectedTime);
            availableTimes.RemoveAll(x => x == timeFromList);
            writeReservationTimes.OverrideListToFile(availableTimes);
            string firstName = UserInput.GetCustomerFirstName();
            string lastName = UserInput.GetCustomerLastName();
            List<Reservation> reservation = new List<Reservation>();
            reservation.Add(new Reservation(timeFromList, new Customer(firstName, lastName)));
            writeReservations.AppendListToFile(reservation);
        }

        public static void ViewReservations()
        {
            List<Reservation> reservations = readReservations.ReadReservationFile();
            Tools.PrintList(reservations);
        }

        public override string ToString()
        {
            return $"{_time}, {Customer}";
        }
    }
}
