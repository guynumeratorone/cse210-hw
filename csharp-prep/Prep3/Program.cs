using System;

class Program
{
    static void Main()
    
    {
        // Initialize random number generator
        Random random = new Random();
        
        // Variable to store the maximum value for the random number
        int valueMax = 0;

        // Display initial instructions for the game
        Console.WriteLine("This is the \"guess a number\" game. ");
        Console.WriteLine("You try to guess a random number in the smallest number of attempts");

        // Prompt user to enter the maximum value for the random number
        while (valueMax <= 1)
        {
            Console.Write("What is the magic number? ");
            
            // Validate and set the maximum value
            if (!int.TryParse(Console.ReadLine(), out valueMax) || valueMax <= 1)
            {
                Console.WriteLine("Please enter a positive integer higher than 1.");
            }
        }

        // Generate a random number within the specified range
        int valueRandom = random.Next(1, valueMax + 1);

        // List to store user guesses
        var userGuesses = new System.Collections.Generic.List<int>();

        // Main loop for user to make guesses
        while (true)
        {
            Console.Write("What is your guess? ");
            
            // Validate and set the user's guess
            if (!int.TryParse(Console.ReadLine(), out int user) || user <= 0)
            {
                Console.WriteLine("Please choose a positive integer greater than 0.");
                continue;
            }

            // Add the user's guess to the list
            userGuesses.Add(user);

            // Check if the guess is correct and provide feedback
            if (user == valueRandom)
            {
                break;
            }
            else if (user > valueRandom)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Too Low");
            }
        }

        // Display the results of the game
        Console.WriteLine($"You were able to find the number in {userGuesses.Count} guesses.");
        Console.Write("Your guesses: ");
        foreach (var guess in userGuesses)
        {
            Console.Write(guess + " ");
        }
    }
}
