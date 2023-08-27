using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaNomes.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] data = csvEmployee.Split(',');
            Name = data[0];
            Salary = Convert.ToDouble(data[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2");
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comaring error: argument is not a Employee");
            }
            Employee emp = obj as Employee;
            return Name.CompareTo(emp.Name);
        }
    }
}
