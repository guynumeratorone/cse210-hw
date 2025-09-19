using System;
using System.IO;

public class JournalLoader
{
    public static void LoadEntryFromFile()
    {
        // Prompts the user for the file name to load
        Console.Write("Enter the file name to load the entry: ");
        string fileName = Console.ReadLine();

        // Combines the desktop folder and file name to create the complete file path
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

        try
        {
            // Reads the contents of users file
            string entry = File.ReadAllText(filePath);
            Console.WriteLine($"Entry loaded successfully from {filePath}:\n{entry}");
        }
        //Will catch errors for user understandng
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading entry: {ex.Message}");
        }
    }
}
