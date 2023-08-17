using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchyAbstract
{
    class Manager : Employee
    {
        public override double CalculateBonus()
        {
            return Salary * 0.20;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bonus : ${CalculateBonus()}");
        }
    }
}
