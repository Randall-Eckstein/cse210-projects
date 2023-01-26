using System;
namespace Develop02;

class Program
{
    public static string filename = "D:\\journalTest.txt";

    public static List<Entry> entries = new List<Entry>();

    static void Main(string[] args)
    {
        SaveLoad saveLoad = new SaveLoad();
        Display displayFile = new Display();
        Prompt prompt = new Prompt();

        Console.WriteLine("Welcome to the journaling software.\n");
        bool canQuit = false;
        while (!canQuit)
        {
            Console.WriteLine("What would you like to do?\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Write\n" +
            "2. Save\n" +
            "3. Display\n" +
            "4. Load\n" +
            "5. Quit");
            Console.ForegroundColor = ConsoleColor.Green;
            int choice = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            switch (choice)
            {
                case 1: 
                    Entry responseList = prompt.PromptGenerator();
                    Program.entries.Add(responseList);
                break;
                case 2: saveLoad.SaveEntries();
                break;
                case 3: 
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    displayFile.DisplayJournal(filename);
                    Console.ForegroundColor = ConsoleColor.White;
                break;
                case 4: 
                    Program.filename = saveLoad.LoadEntries();
                    Console.WriteLine($"Success, new filename is {Program.filename}");
                break;
                case 5: canQuit = true;
                break;
                default: Console.WriteLine("That is not a valid entry.  Please try again.");
                break;
            }
        }
    }
}