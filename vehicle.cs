using System;

// Base class (Superclass)
public class Vehicle
{
    public int MaxSpeed { get; private set; }
    public string FuelType { get; private set; }

    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    // Virtual method to be overridden
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Vehicle: Max Speed = {0} km/h, Fuel Type = {1}",MaxSpeed,FuelType);
    }
}

// Subclass: Car
public class Car : Vehicle
{
    public int SeatCapacity { get; private set; }

    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        SeatCapacity = seatCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Car, Seat Capacity = {0}",SeatCapacity);
    }
}

// Subclass: Truck
public class Truck : Vehicle
{
    public int PayloadCapacity { get; private set; }

    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Truck, Payload Capacity = {0} kg",PayloadCapacity);
    }
}

// Subclass: Motorcycle
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; private set; }

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Motorcycle, Has Sidecar = {HasSidecar}");
    }
}

class Program
{
    static void Main()
    {
        // Creating objects for each vehicle type
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(180, "Petrol", 5),
            new Truck(120, "Diesel", 5000),
            new Motorcycle(150, "Petrol", true)
        };

        // Display details using polymorphism
        Console.WriteLine("Vehicle Details:");
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
