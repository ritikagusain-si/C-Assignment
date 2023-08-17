using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchyAbstract
{
    abstract class Employee
    {
        public string Name { get; set; }

        public int EmployeeId { get; set; }

        public double Salary { get; set; }

        public abstract double CalculateBonus();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Employee Id : {EmployeeId}");
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}
