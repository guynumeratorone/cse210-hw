using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lists to store user's input
        List<int> numbers = new List<int>();

         // Variables to keep track of calculations
        int userInput;
        int sum = 0;
        int total = 0;
        int largestNumber = int.MinValue;

        // Initial message
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to get user input
        do
        {
            Console.Write("Enter your number: ");
            string userInputString = Console.ReadLine();
            // Check if the input is a valid integer
            if (int.TryParse(userInputString, out userInput))
            {
                if (userInput > 0)
                {
                    numbers.Add(userInput);
                    sum += userInput; // Add the entered number to the sum
                    total += userInput; // Add the entered number to the total

                    // Update the largest number if needed
                    if (userInput > largestNumber)
                    {
                        largestNumber = userInput;
                    }
                }
                // Display message for negative input
                else if (userInput < 0)
                {
                    Console.WriteLine("Please enter a positive integer.");
                }
            }
            // Display message for invalid input
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        } while (userInput != 0);

        // Display the entered numbers
        Console.WriteLine("You entered the following numbers:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        // Calculate and display additional statistics
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"\nThe sum of the entered numbers is: {sum}");
            Console.WriteLine($"The total of the entered numbers is: {total}");
            Console.WriteLine($"The average of the entered numbers is: {average:F2}");
            Console.WriteLine($"The largest number entered is: {largestNumber}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }
}
