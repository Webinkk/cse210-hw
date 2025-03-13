using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNum = -1;
        while (userNum != 0)
        {
            Console.Write("Enter a number (enter 0 to quit): ");

            string userInput = Console.ReadLine();
            userNum = int.Parse(userInput);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        //Part 1 - Sum
        int numSum = 0;

        foreach (int number in numbers)
        {
            numSum += number;
        }

        Console.WriteLine($"The sum of the numbers on the list are: {numSum}");

        //Part 2 - Average (add the numbers together numSum then devide by number of values)
        float average = ((float)numSum) / numbers.Count;
        Console.WriteLine($"The average of this list is {average}");

        //Part 3 - Find the max or largest in list
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The max is: {maximum}");
    }
}