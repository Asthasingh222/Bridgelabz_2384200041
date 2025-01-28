using System;

class RandomnNum
{
    //function to calculate roots of the equation
    public static int[] Generate4DigitRandomArray(int size){
       Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            // Generate a random 4-digit number (1000 to 9999)
            array[i] = random.Next(1000, 10000);
        }
        return array;
    }
    public static double[] FindAverageMinMax(int[] numbers){
        double mini=numbers[0],maxi=numbers[0],sum=0;
        for(int i=0;i<numbers.Length;i++){
            mini =Math.Min(mini,numbers[i]);
            maxi=Math.Max(maxi,numbers[i]);
            sum+=numbers[i];
        }
        double avg =sum/numbers.Length;
        return new double[] {mini,maxi,avg};
    }
    static void Main()
    {
            //prompt to take input of a,b,c
            int n=5;
            int[] arr = Generate4DigitRandomArray(n);
            double[] res = FindAverageMinMax(arr);

            // Display results
            Console.WriteLine("Array with random 4 digit values: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //display min,max and avearge
            Console.WriteLine("Minimum , Maximum and Average : ");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]+ " ");
            }
    }
}
