using System;
using System.Collections.Generic;

// Abstract class representing a vehicle
abstract class Vehicle
{
    private string vehicleId;
    private string driverName;
    protected double ratePerKm; // Protected to allow access in subclasses

    // Constructor
    public Vehicle(string id, string driver, double rate)
    {
        this.vehicleId = id;
        this.driverName = driver;
        this.ratePerKm = rate;
    }

    // Encapsulation: Getter methods for private fields
    public string GetVehicleId() { return vehicleId; }
    public string GetDriverName() { return driverName; }

    // Method to display vehicle details
    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: {0}, Driver: {1}, Rate per Km: {2}", vehicleId, driverName, ratePerKm);
    }

    // Abstract method to calculate fare
    public abstract double CalculateFare(double distance);
}

// Interface for GPS functionality
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Car class implementing IGPS interface
class Car : Vehicle, IGPS
{
    private string currentLocation;

    public Car(string id, string driver, double rate) : base(id, driver, rate)
    {
        currentLocation = "Unknown";
    }

    // Overriding CalculateFare for Cars
    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    // Implementing GPS methods
    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Bike class implementing IGPS interface
class Bike : Vehicle, IGPS
{
    private string currentLocation;

    public Bike(string id, string driver, double rate) : base(id, driver, rate)
    {
        currentLocation = "Unknown";
    }

    // Overriding CalculateFare for Bikes (lower rate)
    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm * 0.8; // 20% discount for bikes
    }

    // Implementing GPS methods
    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Auto class implementing IGPS interface
class Auto : Vehicle, IGPS
{
    private string currentLocation;

    public Auto(string id, string driver, double rate) : base(id, driver, rate)
    {
        currentLocation = "Unknown";
    }

    // Overriding CalculateFare for Auto (fixed rate per km)
    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm * 0.9; // 10% discount for autos
    }

    // Implementing GPS methods
    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}

// Main class to test the ride-hailing system
class Program
{
    static void Main()
    {
        // List to store different types of vehicles
        List<Vehicle> vehicles = new List<Vehicle>();

        // Creating vehicles
        Car car = new Car("C101", "Amisha", 10);
        Bike bike = new Bike("B202", "Charlie", 5);
        Auto auto = new Auto("A303", "Charu", 7);

        // Adding vehicles to the list
        vehicles.Add(car);
        vehicles.Add(bike);
        vehicles.Add(auto);

        // Testing ride calculation and GPS functionality
        double distance = 12; // Example distance

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine("Fare for {0} km: ${1}", distance, vehicle.CalculateFare(distance));

            // Checking if the vehicle has GPS functionality (Explicit Casting Fix)
            if (vehicle is IGPS)
            {
                IGPS gpsEnabledVehicle = (IGPS)vehicle; // Explicit cast
                Console.WriteLine("Current Location: " + gpsEnabledVehicle.GetCurrentLocation());

                // Asking user for new location input
                Console.Write("Enter new location for this vehicle: ");
                string newLocation = Console.ReadLine();

                gpsEnabledVehicle.UpdateLocation(newLocation);
                Console.WriteLine("Updated Location: " + gpsEnabledVehicle.GetCurrentLocation());
            }
            Console.WriteLine("--------------------------");
        }
    }
}