using System;
using System.Collections.Generic;
using System.Linq;

// Class to manage the shopping cart
class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>(); // Store product prices
    private LinkedList<KeyValuePair<string, double>> orderedProducts = new LinkedList<KeyValuePair<string, double>>(); // Maintain insertion order
    private SortedDictionary<string, double> sortedProducts = new SortedDictionary<string, double>(); // Store items sorted by product name

    // Method to add a product to the cart
    public void AddProduct(string product, double price)
    {
        if (!productPrices.ContainsKey(product))
        {
            productPrices[product] = price;
            orderedProducts.AddLast(new KeyValuePair<string, double>(product, price));
            sortedProducts[product] = price;
        }
    }

    // Display products in order of insertion
    public void DisplayOrderedProducts()
    {
        Console.WriteLine("Products in the order they were added:");
        foreach (var item in orderedProducts)
        {
            Console.WriteLine(item.Key + ": $" + item.Value);
        }
    }

    // Display products sorted by name
    public void DisplaySortedProducts()
    {
        Console.WriteLine("Products sorted by name:");
        foreach (var item in sortedProducts)
        {
            Console.WriteLine(item.Key + ": $" + item.Value);
        }
    }
}

// Main program to test the shopping cart
class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddProduct("Apple", 1.20);
        cart.AddProduct("Banana", 0.75);
        cart.AddProduct("Orange", 1.50);
        cart.AddProduct("Grapes", 2.00);
        
        // Display products in order of addition
        cart.DisplayOrderedProducts();
        Console.WriteLine();
        
        // Display products sorted by name
        cart.DisplaySortedProducts();
    }
}