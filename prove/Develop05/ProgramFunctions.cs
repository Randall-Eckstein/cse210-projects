using System.Collections.Specialized;
using System.Collections;

namespace Develop05
{
    public class ProgramFunctions
    {
    private List<Goal> goals = new List<Goal>();
    private int _currentTotalPoints;
    private string _currentLevel = "Level 1 - Mighty Fireball";
    private int _nextLevelPoints = 50;
    private string _nextLevelName = "Level 2 - Crimson Gangsta";

    // In order for my program to work correctly I need a dictionary
    // that will preserve the order.  Since the generic dictionary
    // does not do this, I have opted to use the specialized
    // OrderedDictionary.  This does take more memory, but for a small
    // program like this, and a finite dictionary, I feel it is worth
    // the cost.
    private OrderedDictionary _levels = new OrderedDictionary() { 
        {0,    "Level 1 -  Mighty Fireball"},
        {50,   "Level 2 -  Crimson Gangsta"},
        {100,  "Level 3 -  Moose Racer"},
        {200,  "Level 4 -  Nunchuk Raider"},
        {300,  "Level 5 -  Eccentric Raccoon"},
        {400,  "Level 6 -  Wind Ninja"}, 
        {500,  "Level 7 -  Thunder Masher"},
        {600,  "Level 8 -  Light Warrior"},
        {800,  "Level 9 -  Delta Bandit"},
        {1000, "Level 10 -  Retro Fighter"},
        {1250, "Level 11 -  Demolition Kicker"},
        {1500, "Level 12 -  Banzai Clicker"},
        {1750, "Level 13 -  Sneaky Bomber"},
        {2000, "Level 14 -  Dolphin King"},
        {2500, "Level 15 -  Silent Dynamo"},
        {3000, "Level 16 -  Moonlight Falcon"},
        {4000, "Level 17 -  Zulu Spanner"},
        {5000, "Level 18 -  Xtreme Master"} };

    public void MenuController()
    {
        this.GetCurrentLevel();

        bool canQuit = false;
        while (!canQuit)
        {
            Console.Write(
        "Menu Options:\n" +
        "\t1. Create New Goal\n" +
        "\t2. List Goals\n" +
        "\t3. Save Goals\n" +
        "\t4. Load Goals\n" +
        "\t5. Record Event\n" +
        "\t6. Quit\n" +
        "Select a choice from the menu: "
        );

            Console.ForegroundColor = ConsoleColor.Green;
            int choice = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            switch (choice)
            {
                case 1:
                    this.CreateGoal();
                break;

                case 2:

                    this.GetCurrentLevel();
                    foreach (Goal goal in goals)
                    {
                        goal.DisplayGoalStatus();
                    }
                break;

                case 3:
                    Console.Write("What filename would you like to use? (ex: goalsaver.txt) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string filename = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;


                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine($"Internal:{this._currentTotalPoints}<+>{this._nextLevelPoints}<+>{this._currentLevel}<+>{this._nextLevelName}");
                        foreach (Goal goal in goals)
                        {
                            goal.SaveGoal(outputFile);
                        }
                    }
                break;

                case 4:
                    this.LoadGoals();
                break;

                case 5:
                    this.GetCurrentLevel();
                    this.SetCurrentLevel(this.RecordEvent());
                break;

                case 6:
                    canQuit = true;
                break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sorry, that is not a valid choice.  Please try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("What filename would you like to use? (ex: goalsaver.txt) ");
        Console.ForegroundColor = ConsoleColor.Green;
        string filename = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;

        this.goals = new List<Goal>();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] breakdown = line.Split(":");
            string type = breakdown[0];
            string[] parts = breakdown[1].Split("<+>");

            switch (type)
            {
                case "Internal":
                    this._currentTotalPoints = int.Parse(parts[0]);
                    this._nextLevelPoints = int.Parse(parts[1]);
                    this._currentLevel = parts[2];
                    this._nextLevelName = parts[3];
                    this.GetCurrentLevel();
                break;
                
                case "Simple":
                    SimpleGoal simple = new SimpleGoal(int.Parse(parts[0]), parts[1], parts[2], bool.Parse(parts[3]));
                    this.goals.Add(simple);
                break;
                
                case "Lifetime":
                    LifetimeGoal lifetime = new LifetimeGoal(int.Parse(parts[0]), parts[1], parts[2], int.Parse(parts[3]));
                    this.goals.Add(lifetime);
                break;
                
                case "Checklist":
                    ChecklistGoal checklist = new ChecklistGoal(int.Parse(parts[0]), parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    this.goals.Add(checklist);
                break;
                
                default:
                    Console.WriteLine("You've got a bad line of code, sir!");
                break;
            }
        }
    }

    private int RecordEvent()
    {
        Console.WriteLine("The goals are :");
        int number = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"\t{number}. {goal.GetGoalName()}");
            number++;
        }
        Console.Write("Which goal did you accomplish: ");

        Console.ForegroundColor = ConsoleColor.Green;
        int choice = int.Parse(Console.ReadLine()) - 1;
        Console.ForegroundColor = ConsoleColor.White;

        return goals[choice].RecordEvent();
    }

    private void CreateGoal()
    {
        Console.Write(
    "Which type of goal would you like to create:\n" +
    "\t1. Simple Goal\n" +
    "\t2. Lifetime Goal\n" +
    "\t3. Checklist Goal\n" +
    "Select a choice from the menu: "
        );

        Console.ForegroundColor = ConsoleColor.Green;
        int choice = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;

        if (choice == 1)
        {
            SimpleGoal simple = new SimpleGoal();
            this.goals.Add(simple);
        }
        else if (choice == 2)
        {
            LifetimeGoal lifetime = new LifetimeGoal();
            this.goals.Add(lifetime);
        }
        else if (choice == 3)
        {
            ChecklistGoal checklist = new ChecklistGoal();
            this.goals.Add(checklist);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Sorry, that is not a valid choice.  Please try again.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public void SetCurrentLevel(int level)
{
    this._currentTotalPoints += level;

    string tempLevel = "";
    foreach (DictionaryEntry item in this._levels)
    {
        if ((int)item.Key <= this._currentTotalPoints)
        {
            tempLevel = item.Value.ToString();
        }
        else
        {
            this._nextLevelPoints = (int)item.Key;
            this._nextLevelName = item.Value.ToString();
            break;
        }
    }
    this._currentLevel = tempLevel;
}

    public void GetCurrentLevel()
    {
        Console.WriteLine($"You have {this._currentTotalPoints} goal points.");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Your current level is {this._currentLevel}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"You need ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(this._nextLevelPoints - this._currentTotalPoints);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" more goal points to get to ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(this._nextLevelName);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
    }
}