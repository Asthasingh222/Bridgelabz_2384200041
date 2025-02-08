using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; private set; }
    public double Price { get; private set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

// Order class aggregates Products
class Order
{
    public int OrderId { get; private set; }
    private List<Product> products = new List<Product>();

    public Order(int orderId)
    {
        OrderId = orderId;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayOrder()
    {
        Console.WriteLine("Order {0} contains:",OrderId);
        foreach (var product in products)
        {
            Console.WriteLine("- {0} (Rs.{1})",product.Name,product.Price);
        }
    }
}

// Customer places orders
class Customer
{
    public string Name { get; private set; }

    public Customer(string name)
    {
        Name = name;
    }

    public void PlaceOrder(Order order)
    {
        Console.WriteLine("{0} placed an order #{1}.",Name,order.OrderId);
        order.DisplayOrder();
    }
}

class Program
{
    static void Main()
    {
        Product laptop = new Product("Laptop", 1200);
        Product phone = new Product("Phone", 800);

        Order order1 = new Order(101);
        order1.AddProduct(laptop);
        order1.AddProduct(phone);

        Customer customer = new Customer("Jaya");
        customer.PlaceOrder(order1);
    }
}
