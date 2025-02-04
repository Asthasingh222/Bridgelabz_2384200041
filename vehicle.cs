using System;

public class Vehicle
{
    // Instance Variables
    private string ownerName;
    private string vehicleType;

    // Class Variable (Shared across all vehicles)
    private static double registrationFee = 100.0;

    // Constructor
    public Vehicle(string owner, string type)
    {
        ownerName = owner;
        vehicleType = type;
    }

    // Instance Method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner: " + ownerName + ", Vehicle Type: " + vehicleType + ", Registration Fee: " + registrationFee);
    }

    // Class Method
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }

    public static void Main()
    {
        Vehicle car = new Vehicle("Astha", "Car");
        Vehicle bike = new Vehicle("Riya", "Bike");

        car.DisplayVehicleDetails();
        bike.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(150.0);

        car.DisplayVehicleDetails();
        bike.DisplayVehicleDetails();
    }
}
