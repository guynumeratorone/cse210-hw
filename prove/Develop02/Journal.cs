using System;
using System.Collections.Generic;

public class Journal
{
    //Provides user with several topics
    private static List<string> prompts = new List<string>
    {
        "What would you do differently today?: ",
        "What was your favorite part about today?: ",
        "How can you improve your day tomorrow?: ",
        "How many days is you day day day?: ",
        "Enter your fifth prompt about your day?: ",
        "Im running out of things to day?: "
    };

    //This creates a list of strings provided by the users responce to prompts to be saved as one file
    private static List<List<string>> entries = new List<List<string>>();
    private static int currentPromptIndex = 0;

public static void WriteEntry()
{
    // Check if there are more prompts to display
    if (currentPromptIndex < prompts.Count)
    {
        // Display the current prompt to the user
        Console.WriteLine(prompts[currentPromptIndex]);

        // Get the users responce to the current prompt
        string latestEntry = Console.ReadLine();

        // Check if the list for the current prompt exists, if not, create it
        if (entries.Count <= currentPromptIndex)
        {
            entries.Add(new List<string>());
        }

        // Add the user's response to the list associated with the current prompt
        entries[currentPromptIndex].Add($" {latestEntry}");

        // Inform the user that their entry has been recorded
        Console.WriteLine("Entry recorded.");

        // Move to the next prompt
        currentPromptIndex++;
    }
    else
    {
        // Inform the user that they have completed all prompts
        Console.WriteLine("You have completed all prompts.");
    }
}

// Displayes for to the user when called for via the menu.
    public static List<List<string>> GetEntries()
    {
        return entries;
    }

    public static void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No Entries Recorded yet.");
        }
        else
        {
            Console.WriteLine("You wrote.....");
            foreach (var promptEntries in entries)
            {
                Console.WriteLine(string.Join(Environment.NewLine, promptEntries));
            }
        }
    }
}
