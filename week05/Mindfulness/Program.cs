using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (activity == null)
            {
                if (choice == "4") break;
                Console.WriteLine("Invalid choice.");
                Thread.Sleep(1000);
                continue;
            }

            activity.Start();
        }
    }
}
