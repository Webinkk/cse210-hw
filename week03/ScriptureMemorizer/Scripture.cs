using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor that accepts reference and full text of multiple verses.
    public Scripture(string reference, string scriptureText)
    {
        _reference = new Reference(reference);
        _words = new List<Word>();

        // Split the entire scripture into words, ignoring verse numbers.
        string[] wordArray = scriptureText.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Display the scripture without verse numbers
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetDisplayText());
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    // Hide a random word in the scripture
    public void HideRandomWord()
    {
        Random rand = new Random();
        int index;
        do
        {
            index = rand.Next(_words.Count);
        } while (_words[index].GetDisplayText() == new string('_', _words[index].GetText().Length)); // Skip hidden words

        _words[index].Hide();
    }

    // Check if all words have been hidden
    public bool AreAllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (word.GetDisplayText() != new string('_', word.GetText().Length))
            {
                return false;
            }
        }
        return true;
    }
}
