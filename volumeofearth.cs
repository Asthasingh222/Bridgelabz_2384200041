using System;
public class Volume {
    /*Calculates volume of earth*/
    public static void Main(string[] args){
        int r=6378; //radius
        double volume1 = (4/3) * Math.PI * Math.Pow(r,3); //volume of sphere
        double rm=r*0.621371; //conerting radius from km to miles
        double volume2 =(4/3) * Math.PI * Math.Pow(rm,3); //volume of sphere
        Console.WriteLine("The volume of earth in cubic kilometers is "+volume1 + " and cubic miles is "+volume2);
    }
}