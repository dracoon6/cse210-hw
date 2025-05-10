using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Random randomnumber = new Random();
            int magicNumber = randomnumber.Next(1, 101);

            int guess;
            int numberOfGuesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                numberOfGuesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guess != magicNumber);
            Console.Write("Do you want to play again? (yes/no) ");
            string playAgain = Console.ReadLine();
            if (playAgain.ToLower() != "yes")
            {
                break;
            }
        } while (true);
    }
}
