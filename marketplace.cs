using System;
using System.Collections.Generic;

// Abstract class representing a product category
abstract class ProductCategory
{
    public string categoryName { get; set; }

    // Constructor to set category name
    public ProductCategory(string name)
    {
        categoryName = name;
    }
}

// BookCategory class extending ProductCategory
class BookCategory : ProductCategory
{
    public BookCategory() : base("Books") { }
}

// ClothingCategory class extending ProductCategory
class ClothingCategory : ProductCategory
{
    public ClothingCategory() : base("Clothing") { }
}

// Generic Product class with a constraint where T must be a ProductCategory
class Product<T> where T : ProductCategory
{
    public string name { get; set; }  // Name of the product
    public double price { get; set; } // Price of the product
    public T category { get; set; }   // Product category, which is a type of ProductCategory (e.g., BookCategory, ClothingCategory)

    // Constructor to initialize product with name, price, and category
    public Product(string name, double price, T category)
    {
        this.name = name;
        this.price = price;
        this.category = category;
    }

    // Method to display product details
    public void DisplayProduct()
    {
        Console.WriteLine("Product Name: {0}", name);               // Display product name
        Console.WriteLine("Category: {0}", category.categoryName);  // Display product category
        Console.WriteLine("Price: {0} Rs", price);                  // Display product price
    }
}

// Marketplace class with a method to apply discount to any product
class Marketplace
{
    // Generic method to apply discount on a product
    public void ApplyDiscount<T>(Product<T> product, double percentage) where T : ProductCategory
    {
        // Check if the discount percentage is valid
        if (percentage < 0 || percentage > 100)
        {
            Console.WriteLine("Invalid discount percentage.");
            return;
        }

        // Calculate the discount amount and apply the discount
        double disAmount = product.price * (percentage / 100);
        double newPrice = product.price - disAmount;
        product.price = newPrice;  // Update the product's price

        Console.WriteLine("Discount Applied! New Price : {0} Rs", product.price);  // Display the new price after discount
    }
}

// Main program to test product display and discount functionality
class Program
{
    public static void Main()
    {
        // Create instances of products with different categories
        Product<BookCategory> b1 = new Product<BookCategory>("C# Programming", 250, new BookCategory());
        Product<ClothingCategory> c1 = new Product<ClothingCategory>("Shirt", 600, new ClothingCategory());

        // Display initial details of the products
        b1.DisplayProduct();
        c1.DisplayProduct();

        // Create an instance of Marketplace to apply discount
        Marketplace m = new Marketplace();

        // Apply discount to both products
        m.ApplyDiscount(b1, 10);  // 10% discount on book
        m.ApplyDiscount(c1, 15);  // 15% discount on shirt

        // Display updated product details after discount
        b1.DisplayProduct();
        c1.DisplayProduct();
    }
}
