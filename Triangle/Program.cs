using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TriangleWithPerimeter triangle = new TriangleWithPerimeter(5, 12, 13);
            double area = triangle.CalculateArea();
            double perimeter = triangle.CalculatePerimeter();
            Console.WriteLine($"Area: {area}, Perimeter: {perimeter}");
        }
    }
}
