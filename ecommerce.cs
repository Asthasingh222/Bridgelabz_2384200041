using System;
using System.Collections.Generic;

// Abstract class representing a Product
abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public Product(int id, string name, double price)
    {
        this.productId = id;
        this.name = name;
        this.price = price;
    }

    // Encapsulated properties with getters and setters
    public int ProductId { get { return productId; } }
    public string Name { get { return name; } }
    public double Price { get { return price; } set { price = value; } }

    // Abstract method to calculate discount, implemented in derived classes
    public abstract double CalculateDiscount();

    // Method to display product details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Product ID: " + productId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Price: " + price);
    }
}

// Interface for taxable products
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Electronics category
class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10; // 10% discount
    }

    public double CalculateTax()
    {
        return Price * 0.15; // 15% tax
    }

    public string GetTaxDetails()
    {
        return "Tax Rate: 15%";
    }
}

// Clothing category
class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.20; // 20% discount
    }

    public double CalculateTax()
    {
        return Price * 0.05; // 5% tax
    }

    public string GetTaxDetails()
    {
        return "Tax Rate: 5%";
    }
}

// Groceries category (no tax applicable)
class Groceries : Product
{
    public Groceries(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05; // 5% discount
    }
}

// Main program class
class Program
{
   public static void DisplayFinalPrices(List<Product> products)
    {
        foreach (Product product in products)
        {
            product.DisplayDetails();
            double discount = product.CalculateDiscount();

            double tax = 0; // Initialize tax to 0
            if (product is ITaxable) // Check if product implements ITaxable
            {
                ITaxable taxableProduct = (ITaxable)product; // Explicit cast
                tax = taxableProduct.CalculateTax();
            }

            double finalPrice = product.Price + tax - discount;
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Final Price: " + finalPrice);
            Console.WriteLine("-------------------------");
        }
    }

    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        // Creating product instances
        Electronics laptop = new Electronics(101, "Laptop", 50000);
        Clothing tshirt = new Clothing(102, "T-Shirt", 1000);
        Groceries apple = new Groceries(103, "Apple", 200);

        products.Add(laptop);
        products.Add(tshirt);
        products.Add(apple);

        // Display details of each product with final price calculation
        DisplayFinalPrices(products);
    }
}
