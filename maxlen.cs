using System;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

// Apply the attribute to a User class field
class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        if (username.Length > 10)
        {
            throw new ArgumentException("Username exceeds max length of 10 characters.");
        }
        Username = username;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User user = new User("VeryLongUsername");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
