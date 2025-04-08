using System;

class Program
{
    static void Main(string[] args)
    {
        QuestTracker questTracker = new QuestTracker();

        // Adding goals
        questTracker.AddGoal(new SimpleGoal("Run Marathon", "Complete a marathon."));
        questTracker.AddGoal(new EternalGoal("Read Scriptures", "Read your scriptures every day."));
        questTracker.AddGoal(new ChecklistGoal("Attend Temple", "Attend the temple.", 10, 500));

        // Record some events
        questTracker.RecordGoalEvent("Run Marathon");
        questTracker.RecordGoalEvent("Read Scriptures");
        questTracker.RecordGoalEvent("Attend Temple");

        // Show goals and score
        questTracker.DisplayGoals();
        questTracker.ShowTotalScore();

        // Save the goals
        questTracker.SaveGoals("goals.txt");

        // Load the goals
        questTracker.LoadGoals("goals.txt");
    }
}
