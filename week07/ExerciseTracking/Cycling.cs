using System;

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * DurationInMinutes) / 60; // Distance = speed * time
    }

    public override double GetSpeed()
    {
        return speed; // Speed is directly provided
    }

    public override double GetPace()
    {
        return 60 / speed; // Pace = 60 / speed in km/h
    }
}
