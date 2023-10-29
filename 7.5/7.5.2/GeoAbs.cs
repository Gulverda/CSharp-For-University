using System;

// Define an abstract base class for trains
public abstract class Train
{
    public abstract double Gamotvla();
}

// Create the first successor class for calculating the distance traveled
public class DistanceTrain : Train
{
    private double KilometersPerHour { get; }
    private double Hours { get; }

    public DistanceTrain(double kilometersPerHour, double hours)
    {
        KilometersPerHour = kilometersPerHour;
        Hours = hours;
    }

    public override double Gamotvla()
    {
        return KilometersPerHour * Hours;
    }
}

// Create the second successor class for calculating electricity consumption
public class ElectricityTrain : Train
{
    private double EnergyPerKilometer { get; }
    private double Kilometers { get; }

    public ElectricityTrain(double energyPerKilometer, double kilometers)
    {
        EnergyPerKilometer = energyPerKilometer;
        Kilometers = kilometers;
    }

    public override double Gamotvla()
    {
        return EnergyPerKilometer * Kilometers;
    }
}

