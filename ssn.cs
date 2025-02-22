using System;
using System.Text.RegularExpressions;

class SSNValidator
{
    public bool IsValidSSN(string ssn)
    {
        return Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$");
    }

    static void Main()
    {
        SSNValidator validator = new SSNValidator();
        Console.WriteLine("123-45-6789 is valid: " + validator.IsValidSSN("123-45-6789"));
        Console.WriteLine("123456789 is valid: " + validator.IsValidSSN("123456789"));
    }
}
