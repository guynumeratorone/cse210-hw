using System;
using System.Collections.Generic;

// Define a Goal class to hold goal information
public class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Description}) ({Points} points)";
    }
}

public class List
{
    // Define a list to store goals
    private static List<Goal> goals = new List<Goal>();

    // Method to add a new goal to the list
    public static void AddGoal(Goal newGoal)
    {
        goals.Add(newGoal);
    }

    // Method to get the list of goals
    public static List<Goal> GetGoals()
    {
        return goals;
    }

    public static void Prompt()
    {
        Console.WriteLine("Listing Goals:");
        List<Goal> goals = GetGoals();

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
        }
        else
        {
            Console.WriteLine("Your Goals:");
            for (int i = 0; i < goals.Count; i++)
            {
                string completionStatus = goals[i].IsCompleted ? "[X]" : "[ ]";
                Console.WriteLine($"{completionStatus} {goals[i]}");
            }
        }
    }
}
