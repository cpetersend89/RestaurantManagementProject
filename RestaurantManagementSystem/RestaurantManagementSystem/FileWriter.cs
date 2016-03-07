using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class FileWriter
    {
        private readonly string _fileName;

        public FileWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteTerminationToFile(Employee employee)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(employee);
                }
            }
        }

        public void AppendListToFile<T>(List<T> list)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (T obj in list)
                    {
                        sw.WriteLine(obj);
                    }
                }
            }
        }
        public void OverrideListToFile<T>(List<T> list)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (T obj in list)
                    {
                        sw.WriteLine(obj);
                    }
                }
            }
        }
        public void WriteEmployeeFile(Employee employee)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(employee);
                }
            }
        }
    }
}
