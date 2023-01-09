using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);//I originally had .Next(1, 100) but noticed in the solution that it was .Next(1, 101) so it must not be inclusive of the last number
        int guess;
        Console.WriteLine("Guess a number from 1 to 100!");
        do {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        }
        while (guess != magicNumber);
    }
}