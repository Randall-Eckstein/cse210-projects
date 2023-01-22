using System;
namespace Develop02;

class Program
{
    public static string filename = "D:\\journalTest.txt";
    public static string currentPrompt = "";
    public static string currentResponse = "";

    static void Main(string[] args)
    {
        Save saveFile = new Save();
        Display displayFile = new Display();
        Prompt prompt = new Prompt();
        Load loadFilename = new Load();

        Console.WriteLine("Welcome to the journaling software.\n");
        bool canQuit = false;
        while (!canQuit)
        {
            Console.WriteLine("What would you like to do?\n" +
            "1. Write\n" +
            "2. Save\n" +
            "3. Display\n" +
            "4. Load\n" +
            "5. Quit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: List<string> responseList = prompt.prompt();
                currentPrompt = responseList[0];
                currentResponse = responseList[1];
                break;
                case 2: saveFile.save(currentPrompt, currentResponse);
                break;
                case 3: displayFile.display(filename);
                break;
                case 4: loadFilename.load();
                break;
                case 5: canQuit = true;
                break;
                default: Console.WriteLine("That is not a valid entry.  Please try again.");
                break;
            }
        }
    }
}