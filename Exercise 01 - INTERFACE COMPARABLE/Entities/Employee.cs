using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities {
    //------------------------------- START -------------------------------//
    class Employee : IComparable {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1]);
        }
        public override string ToString() {
            return Name + ", " + Salary.ToString("F2");
        }

        public int CompareTo(object obj) {
           if(!(obj is Employee)) {
                throw new ArgumentException("Comparing error: argument is not an Employee");
           }
           Employee other = obj as Employee;
           return Name.CompareTo(other.Name);
        }
    }
    //-------------------------------- END -------------------------------//
}
