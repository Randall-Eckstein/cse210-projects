using System;
namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        bool canQuit = false;

        while (!canQuit)
        {

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Welcome to the Scripture Memorizer.  This program will help you memorize verses of scripture " +
"by gradually hiding random words while you practice.\n\n" +
"Would you like to practice with a single-verse scripture, or a multiple verse scripture?  Type 1 or 2");
        bool correctlyChosen = false;
        int choice = 0;
        while (!correctlyChosen)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                choice = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (choice == 1)
                {
                    Reference scrip = new Reference();
                }
                else if (choice == 2)
                {
                    Reference scrip = new Reference(2);
                }
                else
                {
                    throw new System.ArgumentException("That is not a valid integer for this purpose.");
                }
                correctlyChosen = true;
            }
            catch (System.ArgumentException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sorry, that is not a valid input.\n\nPlease choose 1 for a single-verse scripture, and 2 for a multiple-verse scripture.");
            }
        }

        ConvertTextToList text = new ConvertTextToList();
        Display display = new Display();

        display.DisplayList();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Would you like to try another?  Enter Y or N: ");
        Console.ForegroundColor = ConsoleColor.Green;
        string cont = Console.ReadLine().ToLower();
        if (cont == "y") continue;
        else canQuit = true;
        }
    }
}