using System;
using System.Collections.Generic;
using System.Threading;

public class Listing
{
    private static int durationSeconds; // Declare durationSeconds as a class-level field

    static Listing()
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine();
        Console.WriteLine(@"This activity will help you reflect on good things in your life by having you
        list as many things as you can within a certain amount of time.");
        Console.WriteLine();    
    }

    public static void Prompt()
    {
        Console.WriteLine("How long would you like your session to last, in seconds? 10 seconds or longer.");

        if (!int.TryParse(Console.ReadLine(), out durationSeconds) || durationSeconds <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for the duration.");
            return;
        }

        Console.Clear();
        Console.WriteLine($"Get ready....");
        Cursor.Animate(durationSeconds);

        Console.Clear();
        Console.WriteLine($"List as many responses as you can to the following prompt within {durationSeconds} seconds:");
        Console.WriteLine();
        Console.WriteLine("---When have you felt the Holy Ghost this month?---");
        Console.WriteLine();
        
        DateTime endTime = DateTime.Now.AddSeconds(durationSeconds);
        Dictionary<int, string> responses = new Dictionary<int, string>();
        int index = 1;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
            {
                break; // Exit the loop if the user presses Enter without entering a response
            }
            responses.Add(index++, response); // Add the response to the dictionary
        }

        // Display all collected responses
        Console.Clear();
        Console.WriteLine("Your responses:");
        foreach (var entry in responses)
        {
            Console.WriteLine($"{entry.Key}. {entry.Value}");
        }

        Console.WriteLine("Well done!!");
        Cursor.Animate(durationSeconds);
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have have completed another {durationSeconds} seconds of the Listing Activity.");
        Cursor.Animate(durationSeconds);
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

    }
}
