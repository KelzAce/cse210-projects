using System;

public abstract class Activity
{
    private DateTime date;
    private int durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public DateTime Date
    {
        get { return date; }
    }

    public int DurationInMinutes
    {
        get { return durationInMinutes; }
    }

    public abstract double GetDistance(); // Distance method, to be implemented by subclasses
    public abstract double GetSpeed(); // Speed method, to be implemented by subclasses
    public abstract double GetPace(); // Pace method, to be implemented by subclasses

    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({DurationInMinutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
