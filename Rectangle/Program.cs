using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RectangleHeight rectangle = new RectangleHeight(5, 10);
            double area = rectangle.CalculateArea();
            Console.WriteLine("{area}");
        }
    }
}
