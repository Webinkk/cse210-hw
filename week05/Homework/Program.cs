using System;

namespace HomeworkAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of MathAssignment and WritingAssignment
            MathAssignment mathAssignment = new MathAssignment("John Doe", "Fractions", "7.3", "3-10, 20-21");
            WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

            // Display the summaries and additional information
            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetMathHomeworkList());
            Console.WriteLine();

            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingInfo());
        }
    }
}
