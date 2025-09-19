public class SimpleGoal : Goal
{
    public override string ToString()
    {
        return $"{Name} ({Description}) ({Points} points)";
    }
}
