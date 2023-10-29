using System;

public abstract class TV
{
    public abstract double CalculateElectricityConsumption();
}
public class Television : TV
{
    private double EnergyPerHour { get; }
    private double HoursWorked { get; }

    public Television(double energyPerHour, double hoursWorked)
    {
        EnergyPerHour = energyPerHour;
        HoursWorked = hoursWorked;
    }

    public override double CalculateElectricityConsumption()
    {
        return EnergyPerHour * HoursWorked;
    }
}