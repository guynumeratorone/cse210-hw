public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int BonusPoints { get; set; }
    public int CompletedCount { get; set; } // Added CompletedCount property

    public override string ToString()
    {
        return $"{Name} ({Description}) -- Currently completed {CompletedCount}/{TargetCount}";
    }
}
