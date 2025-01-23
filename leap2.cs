using System;

class Program
{
    static void Main()
    {
        // Prompt user for year 
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        //check if year>=1582
        bool flag=false;
        if(year>=1582)
        {
            //if divisible by 4
            if( year%4==0){

                //if divisible by 100 and 400
                if(year%100==0){
                    if(year%400==0){
                        flag=true;
                    }
                }
                else{
                     flag =true;
                }
                
            }
             
        }
        if(flag==true)  Console.WriteLine("{0} is a leap year.",year); 
        else    Console.WriteLine("{0} is not a leap year.",year);
        
    }
}
