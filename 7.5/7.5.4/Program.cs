using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the monthly salary of the employee: ");
            double monthlySalary = double.Parse(Console.ReadLine());

            Employee fullTimeEmployee = new FullTimeEmployee(monthlySalary);

            double yearlySalary = fullTimeEmployee.CalculateYearlySalary();
            Console.WriteLine("Yearly Salary of the Employee: $" + yearlySalary);
        }
    }
}
