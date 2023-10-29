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
            Rectangle rectangle = new Rectangle(4, 5);
            Triangle triangle = new Triangle(3, 4, 5);

            Console.WriteLine("Rectangle Perimeter: " + rectangle.Perimeter()); // Output: Rectangle Perimeter: 18
            Console.WriteLine("Triangle Perimeter: " + triangle.Perimeter());   // Output: Triangle Perimeter: 12
        }
    }
}
