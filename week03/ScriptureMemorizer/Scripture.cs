using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words { get; set; }
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            int wordsToHide = Math.Min(count, visibleWords.Count);
            for (int i = 0; i < wordsToHide; i++)
            {
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index); // Ensure unique selection
            }
        }
    }

    public bool IsFullyHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{Reference}\n");
        Console.WriteLine(string.Join(" ", Words.Select(word => word.Display())));
    }
}
