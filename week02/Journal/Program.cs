using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        while (true)
        {
            // Display menu
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Write a new entry
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string entryText = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                Entry newEntry = new Entry(date, prompt, entryText);
                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added!\n");
            }
            else if (choice == "2")
            {
                // Display all journal entries
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Save journal to file
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved!\n");
            }
            else if (choice == "4")
            {
                // Load journal from file
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded!\n");
            }
            else if (choice == "5")
            {
                // Exit the program
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.\n");
            }
        }
    }
}