using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        Console.WriteLine("Secretly devising a secret number....");
        Thread.Sleep(500);
        Console.WriteLine("\n...");
        Thread.Sleep(500);
        Console.WriteLine("\n\t...");
        Thread.Sleep(500);
        Console.WriteLine("\n\t\t...");
        Thread.Sleep(500);
        int secret_number = rand.Next(0, 101);
        Console.WriteLine("Secret number has been selected.");

        int guess = -3;
        do
        {
            Console.Write("What is your guess: ");
            bool canContinue = false;
            while (!canContinue)
            {
                try
                {
                    guess = int.Parse(Console.ReadLine());
                    canContinue = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry, that is not a valid number.  Try again.");
                    Console.Write("What is your guess: ");
                }
            }
            if (guess > secret_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < secret_number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Congratulations!  You guessed it!");
            }
        } while (guess != secret_number);

        
    }
}