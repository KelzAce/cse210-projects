using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber;
            int guess = 0;
            int attempts = 0;

            // Step 1: Ask the user to input the magic number
            Console.Write("Enter the magic number: ");
            while (!int.TryParse(Console.ReadLine(), out magicNumber))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            Console.Clear(); // Clears the screen to prevent cheating
            Console.WriteLine("Now, try to guess the number!");

            // Step 2: Loop until the correct number is guessed
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");

                // Step 3: Validate user input
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                attempts++; // Increment guess count

                // Step 4: Give hints
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            }

            // Step 5: Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}
