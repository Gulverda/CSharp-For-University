using System;


public abstract class Employee
{
    protected double MonthlySalary { get; }

    public Employee(double monthlySalary)
    {
        MonthlySalary = monthlySalary;
    }

    public abstract double CalculateYearlySalary();
}

// Create a successor class for employees that calculates yearly salary
public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(double monthlySalary) : base(monthlySalary) { }

    public override double CalculateYearlySalary()
    {
        return MonthlySalary * 12;
    }
}