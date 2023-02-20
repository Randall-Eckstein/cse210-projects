using System;
namespace Develop04;

// In this program I have exceeded the requirements by making sure 
// that there were no repeated prompts during an indivdual
// session of the reflecting activity.
// If the user runs through all the prompts, however,
// the list will repopulate and will draw from the prompts list again.

class Program
{
    static void Main(string[] args)
    {

        int choice = 0;
        while (choice !=4)
        {
            Console.Write("Menu Options:\n" +
"\t1. Start breathing activity\n" +
"\t2. Start reflecting activity\n" +
"\t3. Start listing activity\n" +
"\t4. Quit\n" +
"Select a choise from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int seconds = 0;

            switch (choice)
            {
                case 1:
                    Console.Write("How many seconds would you like to practice your breathing for? ");
                    seconds = int.Parse(Console.ReadLine());
                    Breathing breathe = new Breathing("Breathing", "relax by practicing your breathing.", seconds);
                break;

                case 2:
                    Console.WriteLine("How many seconds would you like to practice reflecting? ");
                    seconds = int.Parse(Console.ReadLine());
                    Reflecting reflect = new Reflecting("reflecting", "reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.", seconds);
                break;

                case 3:
                    Console.WriteLine("How many seconds would you like to spend making a list? ");
                    seconds = int.Parse(Console.ReadLine());
                    Listing list = new Listing("listing", "reflect on the good things in your life by having you list as many things as you can in a certain area.\n", seconds);
                break;

                case 4:
                break;

                default:
                    Console.WriteLine("Sorry, that is not a valid choice.\n");
                break;
            }
            Console.Clear();
        }
    }
}