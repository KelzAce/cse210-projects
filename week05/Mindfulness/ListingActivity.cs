public class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    { }

    public void Run()
    {
        Start();
        Random rand = new();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("You may begin listing items in...");
        ShowCountdown(3);

        List<string> items = new();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            if (Console.KeyAvailable)
            {
                items.Add(Console.ReadLine());
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        End();
    }
}
