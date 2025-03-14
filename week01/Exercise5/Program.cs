using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string userName = GetUserName();
        int userNumber = GetNumber();
        int squaredResult = SquaredNumber(userNumber);

        Result(userName, squaredResult);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int GetNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquaredNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void Result(string name, int squared)
    {
        Console.WriteLine($"{name}, the squre of your number is {squared}");
    }

}