using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello();
}

// Actual implementation
public class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello, welcome!");
    }
}

// Custom Logging Proxy using DispatchProxy
public class LoggingProxy<T> : DispatchProxy where T : class
{
    private T _instance;

    public static T Create(T instance)
    {
        // Create proxy instance
        object proxy = Create<T, LoggingProxy<T>>();

        // Set the actual instance inside the proxy
        ((LoggingProxy<T>)proxy)._instance = instance;

        return (T)proxy;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine("Executing method: " + targetMethod.Name);
        return targetMethod.Invoke(_instance, args);
    }
}

class Program
{
    static void Main()
    {
        // Use an interface for proxying
        IGreeting greeting = new Greeting();

        // Create a proxy instance
        IGreeting proxy = LoggingProxy<IGreeting>.Create(greeting);

        // Call method through proxy
        proxy.SayHello();
    }
}
