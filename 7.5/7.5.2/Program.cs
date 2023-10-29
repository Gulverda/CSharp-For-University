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
            DistanceTrain distanceTrain = new DistanceTrain(80, 3.5);
            ElectricityTrain electricityTrain = new ElectricityTrain(5, 200);

            Console.WriteLine("Distance Traveled: " + distanceTrain.Gamotvla() + " kilometers");
            Console.WriteLine("Electricity Consumed: " + electricityTrain.Gamotvla() + " units");
        }
    }
}
