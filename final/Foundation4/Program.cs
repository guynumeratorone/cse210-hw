using System;

class Program // Program 4: Polymorphism with Exercise Tracking
{
    static void Main(string[] args)
    {
        Console.Clear();
        Activity running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cycling = new Cycling(new DateTime(2022, 11, 3), 30, 12.0);
        Activity swimming = new Swimming(new DateTime(2022, 11, 3), 30, 10);

        Activity[] activities = { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (durationMinutes / 60.0); // in mph
    }

    public override double GetPace()
    {
        return durationMinutes / distance; // pace in minutes per mile
    }
}

public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int durationMinutes, double speed) : base(date, durationMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (durationMinutes / 60.0); // distance in miles
    }

    public override double GetPace()
    {
        return 60.0 / speed; // pace in minutes per mile
    }
}

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0 * 0.62; // distence in miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / (durationMinutes / 60.0); // speed in mph
    }

    public override double GetPace()
    {
        return durationMinutes / GetDistance(); // pace in minutes per mile
    }
}


