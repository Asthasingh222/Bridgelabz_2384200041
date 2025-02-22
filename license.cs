using System;
using System.Text.RegularExpressions;

class LicensePlateValidator
{
    public bool IsValidLicensePlate(string plate)
    {
        return Regex.IsMatch(plate, @"^[A-Z]{2}\d{4}$");
    }

    static void Main()
    {
        LicensePlateValidator validator = new LicensePlateValidator();
        Console.WriteLine(validator.IsValidLicensePlate("AB1234")); // True
        Console.WriteLine(validator.IsValidLicensePlate("A12345")); // False
    }
}
