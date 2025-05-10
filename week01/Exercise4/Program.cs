using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int inputnumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out inputnumber))
            {
                if (inputnumber != 0)
                {
                    numbers.Add(inputnumber);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (inputnumber != 0);

        int sum = FindSum(numbers);
        float average = FindAverage(numbers);
        int largest = FindLargest(numbers);
        int smallestPositive = FindSmallestPositive(numbers);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    static int FindSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static float FindAverage(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return (float)sum / numbers.Count;
    }

    static int FindLargest(List<int> numbers)
    {
        int largest = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        return largest;
    }

    static int FindSmallestPositive(List<int> numbers)
    {
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        return smallestPositive;
    }   
}

