using System;

class Program
{
    static void Main(string[] args)
    {
        Methods m = new Methods();
        
        m.DisplayWelcome();
        string userName = m.PromptUserName();
        int userNumber = m.PromptUserNumber();
        int square = m.SquareNumber(userNumber);
        m.DisplayResult(userName, square);

    }

}

internal class Methods
{
    internal void DisplayWelcome()
    {
        Console.WriteLine("welcome to the Program!");
    }

    internal string PromptUserName()
    {
        Console.WriteLine("What is your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    internal int PromptUserNumber()
    {
        bool canContinue = false;
        int userNumber = int.MaxValue;
        while (!canContinue)
        {
            try
            {
                Console.WriteLine("What is your favorite number: ");
                userNumber = int.Parse(Console.ReadLine());
                canContinue = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, that is not a valid number.  Please try again.");
            }
        }
        return userNumber;
    }

    internal int SquareNumber(int num)
    {
        return (int)MathF.Pow(num, 2);
    }

    internal void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"\n{userName}, the square of your number is {square}");
    }
}
