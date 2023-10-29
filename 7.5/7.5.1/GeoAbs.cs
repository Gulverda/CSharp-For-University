using System;

// Define an abstract base class for geometric figures
public abstract class GeometricFigure
{
    public abstract double Perimeter();
}

// Create the first successor class for rectangles
public class Rectangle : GeometricFigure
{
    private double Length { get; }
    private double Width { get; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double Perimeter()
    {
        return 2 * (Length + Width);
    }
}

// Create the second successor class for triangles
public class Triangle : GeometricFigure
{
    private double Side1 { get; }
    private double Side2 { get; }
    private double Side3 { get; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public override double Perimeter()
    {
        return Side1 + Side2 + Side3;
    }
}

