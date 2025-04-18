class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
            }
            else if (choice == "2")
            {
                new ReflectingActivity().Run();
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again...");
                Console.ReadLine();
            }
        }
    }
}
