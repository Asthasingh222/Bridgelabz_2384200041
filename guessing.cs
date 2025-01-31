using System;

class NumberGuessingGame
{
    static Random random = new Random();

    // Function to generate a random guess within a range
    static int GenerateRandom(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Think of a number between 1 and 100, and I will try to guess it!");

        int min = 1, max = 100;
        bool guessedCorrectly = false;

        while (!guessedCorrectly)
        {
            int guess = GenerateRandom(min, max);
            Console.WriteLine("Is your number {0}? (Enter if the guess is 'high', 'low', or 'correct')",guess);

            string feedback = Console.ReadLine().ToLower();
            
            if (feedback == "correct")
            {
                Console.WriteLine("Great! I guessed your number.");
                guessedCorrectly = true;
            }
            else if (feedback == "high")
            {
                max = guess - 1; // Adjust the upper bound
            }
            else if (feedback == "low")
            {
                min = guess + 1; // Adjust the lower bound
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'high', 'low', or 'correct'.");
            }
        }
    }
}
