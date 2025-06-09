using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Testing Assignment Base Class ---");
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        Console.WriteLine("--- Testing MathAssignment Derived Class ---");
        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();

        Console.WriteLine("--- Testing WritingAssignment Derived Class ---");
        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
        Console.WriteLine();
    }
}
