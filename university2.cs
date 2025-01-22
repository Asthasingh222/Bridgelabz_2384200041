using System;
public class University {
    /*Calculates the discounted amount and final fee after applying a discount percentage.*/
    public static void Main(string[] args){
        Console.Write("Enter fee: ");
        int fee =Convert.ToInt32(Console.ReadLine());//taking input in km
        Console.Write("Enter discount Percentage: ");
        int discountPercent =Convert.ToInt32(Console.ReadLine());//taking input in km
        double discount =(fee *discountPercent)/100; //calculating discounted amount
        double amounttopay=fee-discount; //calculating amount to be paid after discount
        Console.WriteLine("The discount amount is INR "+ discount+" and final discounted fee is INR "+ amounttopay);
    }
}