using System;

// Base class: Order
public class Order
{
    public int OrderId { get; private set; }
    public string OrderDate { get; private set; }

    public Order(int id, string date)
    {
        OrderId = id;
        OrderDate = date;
    }

    // Virtual method to be overridden
    public virtual void GetOrderStatus()
    {
        Console.WriteLine("Order ID: {0}, Date: {1}, Status: Placed",OrderId,OrderDate);
    }
}

// Subclass: ShippedOrder (inherits from Order)
public class ShippedOrder : Order
{
    public string TrackingNumber { get; private set; }

    public ShippedOrder(int id, string date, string tracking)
        : base(id, date)
    {
        TrackingNumber = tracking;
    }

    public override void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine("Tracking Number: {0}, Status: Shipped",TrackingNumber);
    }
}

// Subclass: DeliveredOrder (inherits from ShippedOrder)
public class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate { get; private set; }

    public DeliveredOrder(int id, string date, string tracking, string deliveryDate)
        : base(id, date, tracking)
    {
        DeliveryDate = deliveryDate;
    }

    public override void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine("Delivery Date: {0}, Status: Delivered",DeliveryDate);
    }
}

class Program
{
    static void Main()
    {
        DeliveredOrder order = new DeliveredOrder(1001, "2025-02-08", "TRK12345", "2025-02-10");
        order.GetOrderStatus();
    }
}
