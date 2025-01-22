using System;
public class  Profit {
    public static void Main(string[] args){
        double cp=129;
        double sp=191;
        double profit=sp-cp;
        double profitper=profit/cp *100;
        Console.WriteLine("The Cost Price is INR "+ cp+" and Selling Price is INR "+ sp);
        Console.WriteLine("The Profit is INR "+profit +" and the Profit Percentage is "+ profitper);
    }
}