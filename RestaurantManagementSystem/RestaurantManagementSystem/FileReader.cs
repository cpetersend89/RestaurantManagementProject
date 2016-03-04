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

        public void TerminateEmployee(Employee employee)
        {
            
        } 
    }
}
