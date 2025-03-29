using System;

class Program
{
    static void Main(string[] args)
    {
        // Example Scripture
        string reference = "Proverbs 3:5-6";
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        // Create Scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Display full scripture
        scripture.Display();

        // Main loop
        while (!scripture.AreAllWordsHidden())
        {
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWord();
                scripture.Display();
            }
        }

        // Final message when all words are hidden
        if (scripture.AreAllWordsHidden())
        {
            Console.WriteLine("\nCongratulations! All words are hidden.");
        }
        else
        {
            Console.WriteLine("\nGoodbye!");
        }
    }
}
