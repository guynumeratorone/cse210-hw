public class Points
{
    private int totalPoints;

    public Points()
    {
        totalPoints = 0;
    }

    public void AddPoints(int pointsToAdd)
    {
        if (pointsToAdd > 0)
        {
            totalPoints += pointsToAdd;
            Console.WriteLine($"Added {pointsToAdd} points. Total points: {totalPoints}");
        }
        else
        {
            Console.WriteLine("Invalid points value. Points must be greater than zero.");
        }
    }

    public int GetTotalPoints()
    {
        return totalPoints;
    }

    public void DisplayTotalPoints()
    {
        Console.WriteLine($"Current total points: {totalPoints}");
    }
}
