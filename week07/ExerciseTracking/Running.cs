using System;

public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance; // Distance is directly provided
    }

    public override double GetSpeed()
    {
        return (distance / DurationInMinutes) * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return DurationInMinutes / distance; // Pace in min per km
    }
}
