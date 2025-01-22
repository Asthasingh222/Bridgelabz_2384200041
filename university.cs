using System;
public class University {
    /*Calculates the discounted amount and final fee after applying a discount percentage.*/
    public static void Main(string[] args){
        int fee =125000;
        int discountPercent =10;
        double discount =(fee *discountPercent)/100;
        double amounttopay=fee-discount;
        Console.WriteLine("The discount amount is INR "+ discount+" and final discounted fee is INR "+ amounttopay);
    }
}