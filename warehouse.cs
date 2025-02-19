using System;
using System.Collections.Generic;

// Abstract class representing a warehouse item
abstract class WarehouseItem
{
    public string Name { get; set; }
    public int Price { get; set; }

    public WarehouseItem(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayItem();
}

// Electronics class extending WarehouseItem
class Electronics : WarehouseItem
{
    public Electronics(string name, int price) : base(name, price) { }

    public override void DisplayItem()
    {
        Console.WriteLine("[Electronics] {0} - {1} Rs", Name, Price);
    }
}

// Groceries class extending WarehouseItem
class Groceries : WarehouseItem
{
    public Groceries(string name, int price) : base(name, price) { }

    public override void DisplayItem()
    {
        Console.WriteLine("[Groceries] {0} - {1} Rs", Name, Price);
    }
}

// Furniture class extending WarehouseItem
class Furniture : WarehouseItem
{
    public Furniture(string name, int price) : base(name, price) { }

    public override void DisplayItem()
    {
        Console.WriteLine("[Furniture] {0} - {1} Rs", Name, Price);
    }
}

// Generic Storage class with a constraint ensuring only WarehouseItem types can be stored
class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    // Method to add an item to storage
    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine("{0} is added to storage.", item.Name);
    }

    // Method to display all stored items
    public void DisplayAllItems()
    {
        Console.WriteLine("\nItems in Storage:");
        foreach (var item in items)
        {
            item.DisplayItem();
        }
    }
    // Covariant return type: Allows returning a more general type
    public IEnumerable<T> GetItems()
    {
        return items;  // IEnumerable<T> supports covariance
    }
}

class Program
{
    static void Main()
    {
        // Create storage for Electronics
        Storage<Electronics> elect = new Storage<Electronics>();
        elect.AddItem(new Electronics("Laptop", 40000));
        elect.AddItem(new Electronics("Mouse", 1500));

        // Create storage for Groceries
        Storage<Groceries> groc = new Storage<Groceries>();
        groc.AddItem(new Groceries("Apple", 100));
        groc.AddItem(new Groceries("Milk", 50));

        // Create storage for Furniture
        Storage<Furniture> furn = new Storage<Furniture>();
        furn.AddItem(new Furniture("Chair", 2000));
        furn.AddItem(new Furniture("Table", 5000));

        // Display all stored items
        elect.DisplayAllItems();
        groc.DisplayAllItems();
        furn.DisplayAllItems();

        // Using covariance: Get items as a more general type (WarehouseItem)
        IEnumerable<WarehouseItem> allItems = elect.GetItems();
        Console.WriteLine("\nItems from Electronics storage (covariance):");
        foreach (var item in allItems)
        {
            item.DisplayItem();
        }
    }
}
