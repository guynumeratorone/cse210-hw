using System;
using System.Threading;

public class Reflecting
{
    private static int durationSeconds; // Declare durationSeconds as a class-level field

    static Reflecting()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine();
        Console.WriteLine(@"This activity will help you reflect on times in your life when you have shown strength and resilience. 
This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();    
    }
        
    public static void Prompt()
    {
        Console.WriteLine("How long would you like your session to last, in seconds? 10 seconds are longer.");
        
        if (!int.TryParse(Console.ReadLine(), out durationSeconds) || durationSeconds <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for the duration.");
            return;
        }

        Console.Clear();
        Console.WriteLine($"Get ready....");
        Cursor.Animate(durationSeconds);
        Console.Clear();
        Console.WriteLine($"Get ready....");
        Console.WriteLine();
        Console.WriteLine($"Consider the following Prompt: ");
        Console.WriteLine();
        // Define the list of prompts
        string[] prompts = {
            "---Think of a time when you did something really difficult.---",
            "How did you feel when it was complete?",
            "What was your favorite part about this experience?"
        };

        foreach (var prompt in prompts)
        {
            Console.WriteLine(prompt);
            Thread.Sleep(durationSeconds * 1000); // Wait for the specified duration in seconds
        }

        Console.WriteLine("You have completed all prompts.");

        
    }
    


    
    
}
