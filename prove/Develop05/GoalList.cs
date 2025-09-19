using System.Collections.Generic;

public class GoalList
{
    private List<Goal> goals = new List<Goal>();

    public void SetGoals(List<Goal> newGoals)
    {
        goals = newGoals;
    }

    public List<Goal> GetGoals()
    {
        return goals;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }
}
