using System;
using System.Reflection;

// Define the attribute
[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

// Apply the attribute to methods
class SecureActions
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted.");
    }
}

// Simulate role check and execute the method
class Program
{
    static void Main()
    {
        string userRole = "USER"; // Change to "ADMIN" to allow access
        Type type = typeof(SecureActions);
        object instance = Activator.CreateInstance(type);

        foreach (MethodInfo method in type.GetMethods())
        {
            RoleAllowedAttribute attr = method.GetCustomAttribute<RoleAllowedAttribute>();

            if (attr != null)
            {
                if (attr.Role == userRole)
                {
                    method.Invoke(instance, null);
                }
                else
                {
                    Console.WriteLine("Access Denied!");
                }
            }
        }
    }
}
