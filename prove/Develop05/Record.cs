using System;

public class Record
{
    public static void Prompt()
    {
        DisplayGoals();
        RecordProgress();
    }

    private static void DisplayGoals()
    {
        Console.WriteLine("Select a goal to record progress:");
        List<Goal> goals = List.GetGoals();
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }
    }

private static void RecordProgress()
{
    Console.Write("Enter the number of the goal to record progress: ");
    if (int.TryParse(Console.ReadLine(), out int selectedGoalIndex) && selectedGoalIndex > 0 && selectedGoalIndex <= List.GetGoals().Count)
    {
        Goal selectedGoal = List.GetGoals()[selectedGoalIndex - 1];

        if (selectedGoal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.CompletedCount < checklistGoal.TargetCount)
            {
                // Increment the completed count of the checklist goal
                checklistGoal.CompletedCount++;

                // Add points for each completion
                Program.AddPoints(checklistGoal.Points);

                // Check if all iterations are completed
                if (checklistGoal.CompletedCount == checklistGoal.TargetCount)
                {
                    // Mark the goal as completed
                    selectedGoal.IsCompleted = true;

                    // Add bonus points for completing all iterations
                    Program.AddPoints(checklistGoal.BonusPoints);

                    Console.WriteLine($"Recorded completion of '{selectedGoal.Name}'. Goal marked as completed. Earned {checklistGoal.Points} points for completion and {checklistGoal.BonusPoints} bonus points.");
                }
                else
                {
                    Console.WriteLine($"Progress recorded for '{selectedGoal.Name}'. {checklistGoal.CompletedCount}/{checklistGoal.TargetCount} iterations completed. Earned {checklistGoal.Points} points for completion.");
                }
            }
            else
            {
                Console.WriteLine($"Goal '{selectedGoal.Name}' is already completed.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{selectedGoal.Name}' is not a ChecklistGoal and cannot have progress recorded.");
        }
    }
    else
    {
        Console.WriteLine("Invalid goal selection.");
    }
}
}