using System;
using System.Collections.Generic;
using System.IO;

public class QuestTracker
{
    private List<Goal> goals;
    private int totalScore;

    public QuestTracker()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            totalScore += goal.GetPoints();
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal.Name}: {goal.DisplayStatus()}");
        }
    }

    public void ShowTotalScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.Name},{goal.GetPoints()},{goal.DisplayStatus()}");
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                // For simplicity, we'll add SimpleGoals only for the load
                goals.Add(new SimpleGoal(parts[0], parts[1]));
            }
        }
    }
}
