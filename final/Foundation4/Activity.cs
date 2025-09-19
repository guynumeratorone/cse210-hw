public class Activity
{
    protected DateTime date;
    protected int durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} {GetType().Name} ({durationMinutes} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

