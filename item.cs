using System;

class Program
{
    /// Calculates the total price based on unit price and quantity.
    static void Main()
    {
        Console.Write("Enter unit price: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        double totalPrice = unitPrice * quantity; //calculating total price
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity is " + quantity + " and unit price is INR " + unitPrice);
    }
}
