using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        if (double.TryParse(Console.ReadLine(), out double gradePercentage))
        {
            // Initialize the letter grade variable
            string letter = "";

            // Determine the letter grade based on the percentage
            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Display the letter grade
            Console.WriteLine($"Your letter grade is: {letter}");

            // Check if the user passed the course and display an appropriate message
            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Keep working hard! You can do better next time.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
