using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of different activities
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 5.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 20.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        // Iterate through the list and display the summary of each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
