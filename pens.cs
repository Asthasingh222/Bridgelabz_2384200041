using System;
public class Pens {
    public static void Main(string[] args){
        int pen =14;
        int students=3;
        int rem=pen%students;
        int penperstudent=pen/students;
        Console.WriteLine("The Pen Per Student is "+ penperstudent+" and the remaining pen not distributed is "+rem);
    }
}