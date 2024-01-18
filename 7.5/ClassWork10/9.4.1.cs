using System;

public interface ICalculatePerimeter
{
    double Calculate(double side1, double side2, double side3);
}


public interface ICalculateArea
{
    double Calculate(double baseLength, double height);
}

// Class implementing both interfaces
public class TriangleCalculator : ICalculatePerimeter, ICalculateArea
{
    // Implementing Calculate method for perimeter
    public double Calculate(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    // Implementing Calculate method for area
    public double Calculate(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        TriangleCalculator triangleCalculator = new TriangleCalculator();

        double side1 = 3.0;
        double side2 = 4.0;
        double side3 = 5.0;
        double baseLength = 5.0;
        double height = 8.0;

        double perimeter = triangleCalculator.Calculate(side1, side2, side3);
        double area = triangleCalculator.Calculate(baseLength, height);

        Console.WriteLine($"Perimeter of the triangle: {perimeter}");
        Console.WriteLine($"Area of the triangle: {area}");
    }
}
