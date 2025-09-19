public class Create
{
    public static void Prompt()
    {
        Console.WriteLine("Choose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

public static void CreateSimpleGoal()
{
    Console.Write("What is the name of your goal? ");
    string goalName = Console.ReadLine();
    Console.Write("What is the short description of your goal? ");
    string goalDescription = Console.ReadLine();
    int goalPoints;
    while (true)
    {
        Console.Write("How many points is this goal worth? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out goalPoints))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for points.");
        }
    }

    // Create a new Goal object
    Goal newGoal = new Goal
    {
        Name = goalName,
        Description = goalDescription,
        Points = goalPoints
    };

    // Add the new goal to the list
    List.AddGoal(newGoal);

    Console.WriteLine($"Creating a Simple Goal with name '{goalName}', description '{goalDescription}', and points value '{goalPoints}'");
}


private static void CreateEternalGoal()
{
    Console.Write("What is the name of your goal? ");
    string goalName = Console.ReadLine();
    Console.Write("What is the short description of your goal? ");
    string goalDescription = Console.ReadLine();
    int goalPoints;
    while (true)
    {
        Console.Write("How many points is this goal worth? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out goalPoints))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for points.");
        }
    }

    // Create a new Goal object
    Goal newGoal = new Goal
    {
        Name = goalName,
        Description = goalDescription,
        Points = goalPoints
    };

    // Add the new goal to the list
    List.AddGoal(newGoal);

    Console.WriteLine($"Creating an Eternal Goal with name '{goalName}', description '{goalDescription}', and points value '{goalPoints}'");
}
private static void CreateChecklistGoal()
{
    Console.Write("What is the name of your goal? ");
    string goalName = Console.ReadLine();
    Console.Write("What is the short description of your goal? ");
    string goalDescription = Console.ReadLine();
    int goalPoints;

    while (true)
    {
        Console.Write("How many points is this goal worth? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out goalPoints))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for points.");
        }
    }

    int goalTargetCount;
    while (true)
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out goalTargetCount))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the goal count.");
        }
    }

    int bonusPoints;
    while (true)
    {
        Console.Write("What is the bonus points for accomplishing this goal? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out bonusPoints))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for bonus points.");
        }
    }

    // Create a new ChecklistGoal object
    ChecklistGoal newGoal = new ChecklistGoal
    {
        Name = goalName,
        Description = goalDescription,
        Points = goalPoints,
        TargetCount = goalTargetCount,
        BonusPoints = bonusPoints
    };

    // Add the new goal to the list
    List.AddGoal(newGoal);

    Console.WriteLine($"Creating a Checklist Goal with name '{goalName}', description '{goalDescription}', points '{goalPoints}', target count '{goalTargetCount}', and bonus points '{bonusPoints}'");
}
}