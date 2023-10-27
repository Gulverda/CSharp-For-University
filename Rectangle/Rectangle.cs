using System;

class Rectangle
{
    protected double side1;
    protected double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
}

class RectangleHeight : Rectangle
{
    private double height;

    public RectangleHeight(double side1, double side2) : base(side1, side2)
    {
        this.height = side2;
    }

    public double CalculateArea()
    {
        double s = side1 * side2;
        return s;
    }
}
