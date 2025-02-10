using System;
using System.Collections.Generic;

// Abstract class representing a vehicle
abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public Vehicle(string number, string type, double rate)
    {
        this.vehicleNumber = number;
        this.type = type;
        this.rentalRate = rate;
    }

    // Encapsulation: Using getter methods instead of auto-properties 
    public string GetVehicleNumber() { return vehicleNumber; }
    public string GetTypeName() { return type; }
    public double GetRentalRate() { return rentalRate; }

    // Abstract method to calculate rental cost
    public abstract double CalculateRentalCost(int days);

    // Method to display vehicle details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Vehicle: " + type + ", Number: " + vehicleNumber + ", Rate per day: " + rentalRate);
    }
}

// Interface for insurable vehicles
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Car class implementing IInsurable
class Car : Vehicle, IInsurable
{
    public Car(string number, double rate) : base(number, "Car", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * GetRentalRate() * 1.2; // Car rental has a 20% surcharge
    }

    public double CalculateInsurance()
    {
        return GetRentalRate() * 0.1; // 10% of rental rate as insurance
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance: 10%";
    }
}

// Bike class (not insurable)
class Bike : Vehicle
{
    public Bike(string number, double rate) : base(number, "Bike", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * GetRentalRate(); // No extra charges for bikes
    }
}

// Truck class implementing IInsurable
class Truck : Vehicle, IInsurable
{
    public Truck(string number, double rate) : base(number, "Truck", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * GetRentalRate() * 1.5; // Trucks have a 50% surcharge
    }

    public double CalculateInsurance()
    {
        return GetRentalRate() * 0.2; // 20% insurance cost
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance: 20%";
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(new Car("ABC123", 500));
        vehicles.Add(new Bike("XYZ789", 200));
        vehicles.Add(new Truck("LMN456", 1000));

        foreach (Vehicle v in vehicles)
        {
            v.DisplayDetails();
            Console.WriteLine("Rental Cost for 5 days: " + v.CalculateRentalCost(5));

            // Checking if the vehicle implements IInsurable
            if (v is IInsurable)
            {
                IInsurable insurable = (IInsurable)v;
                Console.WriteLine("Insurance Cost: " + insurable.CalculateInsurance());
                Console.WriteLine(insurable.GetInsuranceDetails());
            }
            Console.WriteLine("------------------------");
        }
    }
}
