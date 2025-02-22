using System;
using System.Text.RegularExpressions;

class CreditCardValidator
{
    // Checks if the given card number is a valid Visa or MasterCard
    public bool IsValidCard(string cardNumber)
    {
        return Regex.IsMatch(cardNumber, @"^(4\d{15}|5\d{15})$"); // Visa starts with 4, MasterCard with 5 (both 16 digits)
    }

    static void Main()
    {
        CreditCardValidator validator = new CreditCardValidator();

        Console.WriteLine("Valid Visa: " + validator.IsValidCard("4123456789012345")); // Should return true
        Console.WriteLine("Valid MasterCard: " + validator.IsValidCard("5123456789012345")); // Should return true
        Console.WriteLine("Invalid Card: " + validator.IsValidCard("3123456789012345")); // Should return false
    }
}
