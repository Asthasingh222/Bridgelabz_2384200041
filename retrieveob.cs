using System;
using System.Reflection;

// 1️⃣ Define Custom Attribute
[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// 2️⃣ Apply the Attribute to a Class
[Author("John Doe")]
class SampleClass
{
    public void Display()
    {
        Console.WriteLine("This is a sample class.");
    }
}

// 3️⃣ Retrieve the Attribute at Runtime
class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);

        // Get the Author attribute
        AuthorAttribute attribute = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        if (attribute != null)
        {
            Console.WriteLine("Author: {0}",attribute.Name);
        }
    }
}
