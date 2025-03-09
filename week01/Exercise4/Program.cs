using System;
using System.Collections.Generic;
using System.Linq; // Required for sorting and calculations

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // Create a list to store user inputs
        int userInput;

        Console.WriteLine("Enter numbers (positive or negative). Enter 0 to stop:");

        // Step 1: Get user input
        while (true)
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out userInput)) // Validate input
            {
                if (userInput == 0) // Stop when 0 is entered
                    break;

                numbers.Add(userInput); // Add number to the list
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        // Step 2: Check if the list is empty
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Step 3: Compute and display the sum
        int sum = numbers.Sum();
        Console.WriteLine($"Sum of numbers: {sum}");

        // Step 4: Compute and display the average
        double average = numbers.Average();
        Console.WriteLine($"Average of numbers: {average:F2}"); // Format to 2 decimal places

        // Step 5: Find and display the maximum number
        int maxNumber = numbers.Max();
        Console.WriteLine($"Maximum number: {maxNumber}");

        // Step 6 (Stretch Challenge): Find the smallest positive number
        int? smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();
        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        else
        {
            Console.WriteLine($"Smallest positive number: {smallestPositive}");
        }

        // Step 7 (Stretch Challenge): Sort and display the numbers
        numbers.Sort();
        Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
    }
}
