using System;

class TravelComputation {
   public static void Main(string[] args) {

      // Create a variable 'name' to indicate the person traveling
      Console.Write("Enter Your name : ");
      string name =Console.ReadLine();
      
      // Create variables 'fromCity', 'viaCity', and 'toCity' for the cities
      Console.Write("Enter the city from which you are traveling: ");
      string fromCity = Console.ReadLine();
      
      Console.Write("Enter the city through which you are traveling ");
      string viaCity = Console.ReadLine();
      
      Console.Write("Enter the city to which you are traveling: ");
      string toCity = Console.ReadLine();

      // Create variables for distances and asking it from user
      Console.Write("Distance from {0} to {1} in miles :",fromCity,viaCity);
      double d1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Distance from {0} to {1} in miles : ",viaCity,toCity);
      double d2 = Convert.ToDouble(Console.ReadLine());
      
      // Create variables for time and asking it from user
      Console.Write("Time taken from {0} to {1}  in hours : ",fromCity,viaCity);
      int timeFromToVia = Convert.ToInt32(Console.ReadLine());

      Console.Write("Time taken from {0} to {1} in hours : ",viaCity,fromCity);
      int timeViaToFinalCity = Convert.ToInt32(Console.ReadLine());

      // Compute the total distance and total time
      double totalDistance = d1 + d2;
      int totalTime = timeFromToVia + timeViaToFinalCity;

      // Print the travel details
      Console.WriteLine("The Total Distance travelled by {0} from {1} to {2} via {3} is {4} km and the Total Time taken is {5} hours",name,fromCity,toCity,viaCity,totalDistance,totalTime);
   }
}
