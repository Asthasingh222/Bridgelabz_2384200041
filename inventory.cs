using System;

class InventoryNode
{
    public string itemName;
    public int itemID;
    public int quantity;
    public double price;
    public InventoryNode next;

    public InventoryNode(string name, int id, int qty, double price)
    {
        this.itemName = name;
        this.itemID = id;
        this.quantity = qty;
        this.price = price;
        this.next = null;
    }
}

class InventoryList
{
    private InventoryNode head;

    // Add an item at the beginning
    public void AddAtBeginning(string name, int id, int qty, double price)
    {
        InventoryNode newNode = new InventoryNode(name, id, qty, price);
        newNode.next = head;
        head = newNode;
    }

    // Add an item at the end
    public void AddAtEnd(string name, int id, int qty, double price)
    {
        InventoryNode newNode = new InventoryNode(name, id, qty, price);
        if (head == null)
        {
            head = newNode;
            return;
        }
        InventoryNode temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }
    // Add an item at a specific position
    public void AddAtPosition(string name, int id, int qty, double price, int position)
    {
        if (position < 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }
        InventoryNode newNode = new InventoryNode(name, id, qty, price);
        if (position == 0)
        {
            newNode.next = head;
            head = newNode;
            return;
        }
        InventoryNode temp = head;
        while (temp != null && position > 1)
        {
            temp = temp.next;
            position--;
        }
        if (temp == null)
        {
            Console.WriteLine("Position out of range.");
            return;
        }
        newNode.next = temp.next;
        temp.next = newNode;
    }

    // Remove an item by Item ID
    public void RemoveItem(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        if (head.itemID == id)
        {
            head = head.next;
            Console.WriteLine("Item removed successfully.");
            return;
        }
        InventoryNode temp = head;
        while (temp.next != null && temp.next.itemID != id)
        {
            temp = temp.next;
        }
        if (temp.next == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }
        temp.next = temp.next.next;
        Console.WriteLine("Item removed successfully.");
    }

    // Update the quantity of an item by Item ID
    public void UpdateQuantity(int id, int qty)
    {
        InventoryNode temp = head;
        while (temp != null && temp.itemID != id)
        {
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }
        temp.quantity = qty;
        Console.WriteLine("Quantity updated successfully.");
    }

    // Search for an item by Item ID
    public void SearchByID(int id)
    {
        InventoryNode temp = head;
        while (temp != null && temp.itemID != id)
        {
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }
        Console.WriteLine("Item Found: {0}, ID: {1}, Quantity: {2}, Price: {3}", temp.itemName, temp.itemID, temp.quantity, temp.price);
    }

    // Search for an item by Item Name
    public void SearchByName(string name)
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            if (temp.itemName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Item Found: {0}, ID: {1}, Quantity: {2}, Price: {3}", temp.itemName, temp.itemID, temp.quantity, temp.price);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Item not found.");
    }

    // Calculate and display total inventory value
    public void CalculateTotalValue()
    {
        double totalValue = 0;
        InventoryNode temp = head;
        while (temp != null)
        {
            totalValue += temp.price * temp.quantity;
            temp = temp.next;
        }
        Console.WriteLine("Total Inventory Value: {0}", totalValue);
    }

    //sort inventory
    public void SortInventory(string sortBy, bool ascending = true)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory List is Empty.");
            return;
        }

        bool swapped = true;
        while (swapped)
        {
            swapped = false;
            InventoryNode curr = head;
            while (curr.next != null)
            {
                bool condition;
                if (sortBy.ToLower() == "name")
                {
                    condition = ascending ?
                        string.Compare(curr.itemName, curr.next.itemName) > 0 :
                        string.Compare(curr.itemName, curr.next.itemName) < 0;
                }
                else if (sortBy.ToLower() == "price")
                {
                    condition = ascending ?
                        curr.price > curr.next.price :
                        curr.price < curr.next.price;
                }
                else
                {
                    Console.WriteLine("Invalid sort parameter.");
                    return;
                }

                if (condition)
                {
                    // Swap the nodes
                    SwapNodes(curr, curr.next);
                    swapped = true;
                }

                curr = curr.next;
            }
        }

        Console.WriteLine("Inventory sorted by {0} in {1} order.",sortBy,(ascending ? "ascending" : "descending"));
    }

    //method to swap two nodes in the inventory list
    private void SwapNodes(InventoryNode node1, InventoryNode node2)
    {
        string tempName = node1.itemName;
        int tempItemId = node1.itemID;
        int tempQuantity = node1.quantity;
        double tempPrice = node1.price;

        node1.itemName = node2.itemName;
        node1.itemID = node2.itemID;
        node1.quantity = node2.quantity;
        node1.price = node2.price;

        node2.itemName = tempName;
        node2.itemID = tempItemId;
        node2.quantity = tempQuantity;
        node2.price = tempPrice;
    }


    // Display all items
    public void DisplayInventory()
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("Item: {0}, ID: {1}, Quantity: {2}, Price: {3}", temp.itemName, temp.itemID, temp.quantity, temp.price);
            temp = temp.next;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        InventoryList inventory = new InventoryList();

        inventory.AddAtEnd("Laptop", 101, 5, 75000);
        inventory.AddAtEnd("Mouse", 102, 10, 500);
        inventory.AddAtEnd("Keyboard", 103, 7, 1500);
        inventory.AddAtEnd("Monitor", 104, 3, 20000);
        inventory.AddAtEnd("Speaker", 105, 4, 2500);

        Console.WriteLine("\n--- Inventory List Before Sorting ---");
        inventory.DisplayInventory();

        Console.WriteLine("\nUpdating Quantity of Mouse to 15");
        inventory.UpdateQuantity(102, 15);
        inventory.DisplayInventory();

        Console.WriteLine("\nSearching for Monitor");
        inventory.SearchByID(104);

        Console.WriteLine("\nCalculating Total Inventory Value");
        inventory.CalculateTotalValue();

        Console.WriteLine("\nRemoving Item with ID 103 (Keyboard)");
        inventory.RemoveItem(103);
        inventory.DisplayInventory();

        Console.WriteLine("\n--- Sorting by Name (Ascending) ---");
        inventory.SortInventory("name", true);
        inventory.DisplayInventory();

        Console.WriteLine("\n--- Sorting by Name (Descending) ---");
        inventory.SortInventory("name", false);
        inventory.DisplayInventory();

        Console.WriteLine("\n--- Sorting by Price (Ascending) ---");
        inventory.SortInventory("price", true);
        inventory.DisplayInventory();

        Console.WriteLine("\n--- Sorting by Price (Descending) ---");
        inventory.SortInventory("price", false);
        inventory.DisplayInventory();
    }
}
