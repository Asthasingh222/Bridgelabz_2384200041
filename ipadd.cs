using System;
using System.Text.RegularExpressions;

class IPValidator
{
    // Method to validate an IPv4 address
    public bool IsValidIP(string ip)
    {
        return Regex.IsMatch(ip, @"^(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])(\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])){3}$");
    }

    static void Main()
    {
        IPValidator validator = new IPValidator();
        string ip = "192.168.1.1";
        Console.WriteLine("Is {0} a valid IP? {1} ",ip,validator.IsValidIP(ip));
    }
}
