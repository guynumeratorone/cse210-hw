using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Start Breathing Activity.");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity.");
            Console.WriteLine("4. Press 4 to quit.");

            Console.WriteLine("Select a choice from the menu: "); // Prompt the user for input
            string userInput = Console.ReadLine();

            Console.Clear();
            switch (userInput)
            {
                case "1":
                    Breathing.Prompt();
                    break;

                case "2":
                    Reflecting.Prompt();
                    break;

                case "3":
                    Listing.Prompt();
                    break;

                case "4":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Please choose a number between 1 and 4.");
                    break;
            }
            
        } while (!quit); 
        
        Console.Clear();
    }   
}
