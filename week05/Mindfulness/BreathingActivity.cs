public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        Start();
        int interval = 4;
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in...");
            ShowCountdown(interval);
            Console.Write("Breathe out...");
            ShowCountdown(interval);
        }

        End();
    }
}
