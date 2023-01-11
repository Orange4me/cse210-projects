using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 21);
        int Guess = 21;
        string guess = "21";

        while (Guess != number)
        {
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            Guess = Int16.Parse(guess);


            
            if (Guess > number)
            {
            Console.WriteLine("Lower");
            }
            else if (Guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}