using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class FileReader
    {
        private readonly string _fileName;

        public FileReader(string fileName)
        {
            _fileName = fileName;
        }

        public string ReadStringFile()
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        public List<Employee> ReadEmployeeFile()
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    List<Employee> employees = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        if (str != null)
                        {
                            string[] parseString = str.Split(',');
                            employees.Add(new Employee(int.Parse(parseString[0]), parseString[1], parseString[2], parseString[3], parseString[4]));
                        }
                    }
                    return employees;
                }
            }
        }

        public List<Reservation> ReadReservationFile()
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    List<Reservation> reservations = new List<Reservation>();
                    while (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        if (str != null)
                        {
                            string[] parseString = str.Split(',');
                            reservations.Add(new Reservation(int.Parse(parseString[0]), new Customer(parseString[1], parseString[2])));
                        }
                    }
                    return reservations;
                }
            }
        } 

        public List<int> ReadIntList()
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    List<int> list = new List<int>();
                    while (!sr.EndOfStream)
                    {
                        int str = int.Parse(sr.ReadLine());
                        list.Add(str);
                    }
                    return list;
                }
            }
        }     
    }
}
