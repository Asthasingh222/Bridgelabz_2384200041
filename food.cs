using System;
using System.Collections.Generic;

// Abstract class representing a Food Item
abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    // Constructor to initialize food item
    public FoodItem(string name, double price, int quantity)
    {
        this.itemName = name;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to display item details
    public void GetItemDetails()
    {
        Console.WriteLine("Item: " + itemName + ", Price: " + price + ", Quantity: " + quantity);
    }

    // Abstract method to be implemented by subclasses
    public abstract double CalculateTotalPrice();
}

// Interface for discountable items
interface IDiscountable
{
    void ApplyDiscount(double percentage); // Apply discount to an item
    double GetDiscountDetails(); // Get the discounted price
}

// VegItem class implementing discountable interface
class VegItem : FoodItem, IDiscountable
{
    private double discount;
    
    public VegItem(string name, double price, int quantity) : base(name, price, quantity)
    {
        discount = 0;
    }

    // Calculate total price with discount
    public override double CalculateTotalPrice()
    {
        return (price * quantity) - discount;
    }

    // Applying discount
    public void ApplyDiscount(double percentage)
    {
        discount = (price * quantity) * (percentage / 100);
        Console.WriteLine(itemName + " discount applied: " + discount);
    }

    // Get discount details
    public double GetDiscountDetails()
    {
        return discount;
    }
}

// NonVegItem class implementing discountable interface
class NonVegItem : FoodItem, IDiscountable
{
    private double extraCharge;
    private double discount;
    
    public NonVegItem(string name, double price, int quantity) : base(name, price, quantity)
    {
        extraCharge = 20; // Extra charge for non-veg items
        discount = 0;
    }

    // Calculate total price including extra charge and discount
    public override double CalculateTotalPrice()
    {
        return ((price * quantity) + extraCharge) - discount;
    }

    // Applying discount
    public void ApplyDiscount(double percentage)
    {
        discount = ((price * quantity) + extraCharge) * (percentage / 100);
        Console.WriteLine(itemName + " discount applied: " + discount);
    }

    // Get discount details
    public double GetDiscountDetails()
    {
        return discount;
    }
}

// Main class to test the food delivery system
class Program
{
    static void Main()
    {
        // Creating a list of food items
        List<FoodItem> foodItems = new List<FoodItem>();
        foodItems.Add(new VegItem("Paneer Butter Masala", 200, 2));
        foodItems.Add(new NonVegItem("Chicken Biryani", 300, 1));

        // Iterating through each item and displaying details
        foreach (FoodItem item in foodItems)
        {
            item.GetItemDetails();
            Console.WriteLine("Total Price: " + item.CalculateTotalPrice());
            
            // Checking if the item is discountable
            if (item is IDiscountable)
            {
                IDiscountable discountableItem = (IDiscountable)item;
                discountableItem.ApplyDiscount(10); // Applying 10% discount
                Console.WriteLine("Price after discount: " + item.CalculateTotalPrice());
            }
            Console.WriteLine("-------------------------");
        }
    }
}