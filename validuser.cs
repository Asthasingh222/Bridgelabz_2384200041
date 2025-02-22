using System;
using System.Text.RegularExpressions;

class UsernameValidator
{
    public bool IsValidUsername(string username)
    {
        return Regex.IsMatch(username, @"^[A-Za-z][A-Za-z0-9_]{4,14}$");
    }

    static void Main()
    {
        UsernameValidator validator = new UsernameValidator();
        Console.WriteLine(validator.IsValidUsername("user_123")); // True
        Console.WriteLine(validator.IsValidUsername("123user"));  // False
    }
}
