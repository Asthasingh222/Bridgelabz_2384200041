using System;

class CarRental
{
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    public const double RatePerDay = 10000;

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
    }

    public double CalculateTotalCost()
    {
        return RentalDays * RatePerDay;
    }

    static void Main()
    {
        CarRental rental = new CarRental("Megha", "BMW", 5);
        Console.WriteLine("Customer: {0}, Total Cost: ,{1}",rental.CustomerName,rental.CalculateTotalCost());
    }
}
