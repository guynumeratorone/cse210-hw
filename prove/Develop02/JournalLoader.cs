using System;
using System.IO;

public class JournalLoader
{
    public static void LoadEntryFromFile()
    {
        // Prompt the user for the file name to load
        Console.Write("Enter the file name to load the entry: ");
        string fileName = Console.ReadLine();

        // Combine the desktop folder and file name to create the complete file path
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

        try
        {
            // Read the contents of the file
            string entry = File.ReadAllText(filePath);
            Console.WriteLine($"Entry loaded successfully from {filePath}:\n{entry}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading entry: {ex.Message}");
        }
    }
}
