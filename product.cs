using System;

class Product
{
    public string ProductName;
    public double Price;
    public static int TotalProducts = 0;

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
        TotalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product: {0}, Price: {1}",ProductName,Price);
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: {0}",TotalProducts);
    }

    static void Main()
    {
        Product p1 = new Product("Laptop", 10000);
        Product p2 = new Product("Mouse", 200);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();
        DisplayTotalProducts();
    }
}
