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
            Console.Write("Enter the energy consumption per hour (in watts): ");
            double energyPerHour = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of hours the TV worked: ");
            double hoursWorked = double.Parse(Console.ReadLine());

            TV television = new Television(energyPerHour, hoursWorked);

            double electricityConsumed = television.CalculateElectricityConsumption();
            Console.WriteLine("Electricity Consumed by the TV: " + electricityConsumed + " watt-hours");
        }
    }
}
