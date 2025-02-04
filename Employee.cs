using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal abstract class Employee
    {
        abstract public void CalculateSalary();
    }
    internal class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Full Time Employee Salary Calculated");
        }
    }
    internal class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Part Time Employee Salary Calculated");
        }
    }
}
