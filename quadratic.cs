using System;

class Quadratic
{
    //function to calculate roots of the equation
    public static double[] FindRoots(double delta,double a,double b,double c){
      if(delta >0){
        double root1= (-b +Math.Sqrt(delta))/(2*a);
        double root2= (-b -Math.Sqrt(delta))/(2*a);
        return new double[] {root1,root2};
      }
      else if(delta == 0){
        double root = -b/(2*a);
        return new double[] {root};
      }
      else return new double[] {};
    }
    static void Main()
    {
            //prompt to take input of a,b,c
            Console.WriteLine("Enter values of a, b, c to find roots of the equation ax^2 +bx +c: ");
            Console.Write("Enter value of a: ");
            double a= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of b: ");
            double b= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of c: ");
            double c= Convert.ToDouble(Console.ReadLine());
        
            double delta =Math.Pow(b,2) - 4*a*c;

            double[] roots =FindRoots(delta,a,b,c);

            // Display results
            Console.WriteLine("Roots of equation : {0}x^2 + {1}x + {2} : ",a,b,c);
            for (int i = 0; i < roots.Length; i++)
            {
                Console.WriteLine(roots[i]);
            }
    }
}
