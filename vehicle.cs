using System;

public class Vehicle
{
    private string owner;
    private string vehicleType;
    private readonly int regNumber;
    private static double registrationFee = 100.0;

    // Constructor
    public Vehicle(string owner, string vehicleType, int regNumber)
    {
        this.owner = owner;
        this.vehicleType = vehicleType;
        this.regNumber = regNumber;
    }

    // Getter methods
    public string GetOwner() { return owner; }
    public string GetVehicleType() { return vehicleType; }
    public int GetRegNumber() { return regNumber; }
    public static double GetRegistrationFee() { return registrationFee; }

    // Display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner: " + GetOwner() + ", Vehicle Type: " + GetVehicleType() +
                          ", Registration Number: " + GetRegNumber() +
                          ", Registration Fee: " + GetRegistrationFee());
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }

    public static void Main()
    {
        Vehicle car = new Vehicle("Astha", "Car", 123);
        Vehicle bike = new Vehicle("Riya", "Bike", 345);

        if (car is Vehicle) car.DisplayVehicleDetails();
        if (bike is Vehicle) bike.DisplayVehicleDetails();

        // Updating registration fee
        Vehicle.UpdateRegistrationFee(150.0);

        car.DisplayVehicleDetails();
        bike.DisplayVehicleDetails();
    }
}
