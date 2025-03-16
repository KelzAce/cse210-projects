using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsFullyHidden())
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords();
        }

        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Press any key to exit.");
        Console.ReadKey();
    }

    static List<Scripture> LoadScripturesFromFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (File.Exists(filename))
        {
            foreach (var line in File.ReadAllLines(filename))
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 3)
                {
                    Reference reference = new Reference(parts[0], int.Parse(parts[1]));
                    scriptures.Add(new Scripture(reference, parts[2]));
                }
            }
        }
        return scriptures;
    }
}
