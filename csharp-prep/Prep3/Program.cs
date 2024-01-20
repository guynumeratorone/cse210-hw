using System;

class Program
{
    static void Main()
    
    {
        Random random = new Random();
        int valueMax = 0;

        Console.WriteLine("This is the \"guess a number\" game.");
        Console.WriteLine("You try to guess a random number in the smallest number of attempts");

        while (valueMax <= 1)
        {
            Console.Write("What is the magic number? ");
            if (!int.TryParse(Console.ReadLine(), out valueMax) || valueMax <= 1)
            {
                Console.WriteLine("Please enter a positive integer higher than 1.");
            }
        }

        int valueRandom = random.Next(1, valueMax + 1);

        var userGuesses = new System.Collections.Generic.List<int>();

        while (true)
        {
            Console.Write("What is your guess? ");
            if (!int.TryParse(Console.ReadLine(), out int user) || user <= 0)
            {
                Console.WriteLine("Please choose a positive integer greater than 0.");
                continue;
            }

            userGuesses.Add(user);

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

        Console.WriteLine($"You were able to find the number in {userGuesses.Count} guesses.");
        Console.Write("Your guesses: ");
        foreach (var guess in userGuesses)
        {
            Console.Write(guess + " ");
        }
    }
}
