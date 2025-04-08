using System;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    protected int pointsEarned;
    
    public Goal(string name, string description)
    {
        Name = name;
        Description = description;
        pointsEarned = 0;
    }

    public abstract void RecordEvent();
    public abstract int GetPoints();
    public abstract string DisplayStatus();
}

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description) : base(name, description) {}

    public override void RecordEvent()
    {
        pointsEarned += 1000;  // Example points for a simple goal
    }

    public override int GetPoints()
    {
        return pointsEarned;
    }

    public override string DisplayStatus()
    {
        return pointsEarned > 0 ? "[X] Completed" : "[ ] Not Completed";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description) : base(name, description) {}

    public override void RecordEvent()
    {
        pointsEarned += 100;  // Example points for each time the goal is completed
    }

    public override int GetPoints()
    {
        return pointsEarned;
    }

    public override string DisplayStatus()
    {
        return $"[ ] Ongoing - {pointsEarned} points earned";
    }
}

public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int targetTimes;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int targetTimes, int bonusPoints) : base(name, description)
    {
        this.targetTimes = targetTimes;
        this.bonusPoints = bonusPoints;
        timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        timesCompleted++;
        pointsEarned += 50;  // Points per completion
        if (timesCompleted == targetTimes)
        {
            pointsEarned += bonusPoints;  // Bonus on completion of target
        }
    }

    public override int GetPoints()
    {
        return pointsEarned;
    }

    public override string DisplayStatus()
    {
        return $"Completed {timesCompleted}/{targetTimes} times - {pointsEarned} points";
    }
}
