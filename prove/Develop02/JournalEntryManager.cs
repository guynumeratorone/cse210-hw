public class JournalEntryManager
{
    public static void SaveEntriesToFile(List<List<string>> allEntries)
    {
        // Get the current user's desktop folder
        string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // Prompt the user for the file name
        Console.Write("Enter the file name to save the entries: ");
        string fileName = Console.ReadLine();

        // Combine the desktop folder and file name to create the complete file path
        string filePath = Path.Combine(desktopFolder, fileName);

        try
        {
            // Write all entries to the file
            File.WriteAllLines(filePath, allEntries.SelectMany(entries => entries));
            Console.WriteLine($"Entries saved successfully to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving entries: {ex.Message}");
        }
    }
}
