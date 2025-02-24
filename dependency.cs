using System;
using System.Collections.Generic;
using System.Reflection;

// Step 1: Define an Interface
public interface IService
{
    void Execute();
}

// Step 2: Create Concrete Implementation
public class ServiceA : IService
{
    public void Execute()
    {
        Console.WriteLine("ServiceA is executing...");
    }
}

// Step 3: Create a Simple Dependency Injection Container
public class DIContainer
{
    private Dictionary<Type, Type> _typeMappings = new Dictionary<Type, Type>();

    // Register Interface -> Concrete Implementation
    public void Register<TInterface, TImplementation>() where TImplementation : TInterface
    {
        _typeMappings[typeof(TInterface)] = typeof(TImplementation);
    }

    // Resolve Dependency (Create Instance of Registered Type)
    public T Resolve<T>()
    {
        Type type = typeof(T);

        if (!_typeMappings.ContainsKey(type))
        {
            throw new Exception("No implementation registered for " + type.Name);
        }

        Type implementationType = _typeMappings[type];
        return (T)Activator.CreateInstance(implementationType);
    }
}

class Program
{
    static void Main()
    {
        // Step 4: Register Dependencies
        DIContainer container = new DIContainer();
        container.Register<IService, ServiceA>(); // Map IService -> ServiceA

        // Step 5: Resolve and Use the Dependency
        IService service = container.Resolve<IService>();
        service.Execute();
    }
}
