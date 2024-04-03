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

            // Check if the goal is already completed
            if (!selectedGoal.IsCompleted)
            {
                // Get points from the selected goal
                int pointsEarned = selectedGoal.Points;

                // Mark the goal as completed
                selectedGoal.IsCompleted = true;

                // Add points to the total
                Program.AddPoints(pointsEarned);

                Console.WriteLine($"Recorded {pointsEarned} points for {selectedGoal.Name}. Goal marked as completed.");
            }
            else
            {
                Console.WriteLine($"Goal '{selectedGoal.Name}' is already marked as completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
}
