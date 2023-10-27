using System;


class Triangle
{
    protected double side1;
    protected double side2;
    protected double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1; 
        this.side2 = side2; 
        this.side3 = side3;
    }
}

class TriangleWithPerimeter : Triangle
{
    private double perimeter;
    public TriangleWithPerimeter(double side1, double side2, double side3) : base(side1, side2, side3)
    {
        perimeter = side1 + side2 + side3;
    }

    public double CalculateArea()
    {
        double s = perimeter / 2;
        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        return area;
    }

    public double CalculatePerimeter()
    {
        return perimeter;
    }
}

