using System;

class Program
{
    static void Main()
    {
        bool quit = false;

        do
        {
           
            // Display menu options
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            // Get user input
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();

            // Process the user input via switch
            switch (userInput)
            {
                
                case "1":
                    Journal.WriteEntry();
                    break;

                case "2":
                    Journal.DisplayEntries();
                    break;

                case "3":
                    JournalLoader.LoadEntryFromFile();
                    break;

                case "4":
                    JournalEntryManager.SaveEntriesToFile(Journal.GetEntries());
                    break;

                case "5":
                    Console.WriteLine("This is Quit");
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
                
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        } while (!quit);

    }
}