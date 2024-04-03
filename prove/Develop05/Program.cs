// Inside Program.cs

using System;

class Program
{
    private static int totalPoints = 0;

    static void Main(string[] args)
    {
        bool quit = false;
        int outerSwitchValue;

        do
        {
            Console.WriteLine("These are your points:");
            DisplayTotalPoints();
            Console.WriteLine();
            Console.WriteLine("1. Create a NEW Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Progress");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out outerSwitchValue))
            {
                Console.WriteLine("Please choose an option between 1 and 6.");
                continue;
            }
            Console.Clear();

            switch (outerSwitchValue)
            {
                case 1:
                    Create.Prompt();
                    break;
                case 2:
                    List.Prompt();
                    break;
                case 3:
                    SaveLoad.Save(List.GetGoals());
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case 4:
                    GoalList goalList = new GoalList();
                    goalList.SetGoals(SaveLoad.Load());
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case 5:
                    Record.Prompt();
                    break;
                case 6:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        } while (!quit);
    }

    public static void AddPoints(int points)
    {
        totalPoints += points;
    }

    public static void DisplayTotalPoints()
    {
        Console.WriteLine($"Total Points: {totalPoints}");
    }
}
