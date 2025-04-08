using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Distance in km (each lap is 50 meters)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); // Pace in min per km
    }
}
