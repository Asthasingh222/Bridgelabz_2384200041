using System;

// Base class: Vehicle
public class Vehicle
{
    protected int MaxSpeed;
    protected string Model;

    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Vehicle Model: " + Model);
        Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
    }
}

// Interface: Refuelable
public interface Refuelable
{
    void Refuel();
}

// Subclass: ElectricVehicle (inherits from Vehicle)
public class ElectricVehicle : Vehicle
{
    public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    public void Charge()
    {
        Console.WriteLine("Charging the electric vehicle.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Vehicle Type: Electric");
    }
}

// Subclass: PetrolVehicle (inherits from Vehicle, implements Refuelable)
public class PetrolVehicle : Vehicle, Refuelable
{
    public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    public void Refuel()
    {
        Console.WriteLine("Refueling the petrol vehicle.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Vehicle Type: Petrol");
    }
}

class Program
{
    static void Main()
    {
        ElectricVehicle ev = new ElectricVehicle(150, "Tesla Model 3");
        PetrolVehicle pv = new PetrolVehicle(180, "Toyota Corolla");

        ev.DisplayInfo();
        ev.Charge();
        Console.WriteLine();

        pv.DisplayInfo();
        pv.Refuel();
    }
}
