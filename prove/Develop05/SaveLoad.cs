using System;
using System.Collections.Generic;
using System.IO;

public static class SaveLoad
{
    private const string SaveFileName = "goals.txt"; // File name for saving goals

    public static void Save(List<Goal> goals)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, SaveFileName);

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var goal in goals)
                {
                    string goalString = GoalToString(goal);
                    writer.WriteLine(goalString);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public static List<Goal> Load()
    {
        List<Goal> loadedGoals = new List<Goal>();
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, SaveFileName);

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Goal goal = StringToGoal(line);
                    if (goal != null)
                    {
                        loadedGoals.Add(goal);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }

        return loadedGoals;
    }

    public static string GoalToString(Goal goal)
    {
        if (goal is ChecklistGoal checklistGoal)
        {
            return $"ChecklistGoal:{checklistGoal.Name},{checklistGoal.Description},{checklistGoal.Points}," +
                   $"{checklistGoal.IsCompleted},{checklistGoal.BonusPoints},{checklistGoal.TargetCount},{checklistGoal.CompletedCount}";
        }
        else
        {
            return $"{goal.GetType().Name}:{goal.Name},{goal.Description},{goal.Points},{goal.IsCompleted}";
        }
    }

    private static Goal StringToGoal(string goalString)
    {
        string[] parts = goalString.Split(':');
        if (parts.Length == 2)
        {
            string[] data = parts[1].Split(',');
            if (data.Length >= 7)
            {
                string type = parts[0];
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                bool isCompleted = bool.Parse(data[3]);
                int bonusPoints = int.Parse(data[4]);
                int targetCount = int.Parse(data[5]);
                int completedCount = int.Parse(data[6]);

                switch (type)
                {
                    case "SimpleGoal":
                        return new SimpleGoal { Name = name, Description = description, Points = points, IsCompleted = isCompleted };
                    case "EternalGoal":
                        return new EternalGoal { Name = name, Description = description, Points = points, IsCompleted = isCompleted };
                    case "ChecklistGoal":
                        return new ChecklistGoal { Name = name, Description = description, Points = points, IsCompleted = isCompleted,
                            BonusPoints = bonusPoints, TargetCount = targetCount, CompletedCount = completedCount };
                }
            }
        }
        return null;
    }
}
