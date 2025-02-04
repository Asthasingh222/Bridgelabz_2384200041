using System;

class Product
{
    private static double discount = 15;
    private readonly int productID;
    private string productName;
    private double price;
    private int quantity;

    public static double GetDiscount()
    {
        return discount;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        discount = newDiscount;
    }

    // Constructor
    public Product(int productID, string productName, double price, int quantity)
    {
        this.productID = productID;
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }

    // Getter methods
    public int GetProductID() { return productID; }
    public string GetProductName() { return productName; }
    public double GetPrice() { return price; }
    public int GetQuantity() { return quantity; }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product: " + GetProductName() + ", Product ID: " + GetProductID() +
                          ", Price: " + GetPrice() + ", Quantity: " + GetQuantity() +
                          ", Discount Percentage: " + GetDiscount());
    }

    public static void Main()
    {
        Product p1 = new Product(123, "Laptop", 10000, 10);
        Product p2 = new Product(345, "Mouse", 1000, 15);

        if (p1 is Product) p1.DisplayProductDetails();
        if (p2 is Product) p2.DisplayProductDetails();
    }
}
