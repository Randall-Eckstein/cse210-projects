using System.Collections.Specialized;
using System.Collections;

namespace Develop05
{
    public abstract class Goal
    {
#region UniversalVariables
        // Universal Variables
        private int _pointValue;
        private int _timesCompleted;
        private string _goalName;
        private string _goalDescription;
#endregion UniversalVariables

#region Constructors
        // Empty constructor for new goals
        public Goal()
        {
        }

        // Constructor with parameters for loading
        public Goal(int pointValue, string goalName, string description)
        {
            this._pointValue = pointValue;
            this._goalName = goalName;
            this._goalDescription = description;
        }
#endregion

#region UniversalMethods
        public void SetPointValue(int value)
        {
            this._pointValue = value;
        }

        public int GetPointValue()
        {
            return this._pointValue;
        }

        public void SetTimesCompleted(int times)
        {
            this._timesCompleted = times;
        }

        public void IncreaseTimesCompleted()
        {
            this._timesCompleted += 1;
        }

        public int GetTimesCompleted()
        {
            return this._timesCompleted;
        }

        public void SetGoalName(string goalName)
        {
            this._goalName = goalName;
        }

        public string GetGoalName()
        {
            return this._goalName;
        }

        public void SetGoalDescription(string description)
        {
            this._goalDescription = description;
        }

        public string GetGoalDescription()
        {
            return this._goalDescription;
        }

        public void SetCommonGoalDetails()
        {
            Console.Write("What is the name of your goal? ");
            Console.ForegroundColor = ConsoleColor.Green;
            string goalName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            this.SetGoalName(goalName);

            Console.Write("What is a description of your goal: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string description = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            this.SetGoalDescription(description);

            bool canContinue = false;
            int points = 0;
            while (!canContinue)
            {
                try
                {
                    Console.WriteLine("How many points is it worth each time you complete this goal? ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    points = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    canContinue = true;
                }
                catch (FormatException)
                {
                    Console.Write("Sorry, I didn't get that.  Please try again.");
                }
            }
            this._pointValue = points;
        }
#endregion UniversalMethods

#region AbstractMethods
        public abstract void SetGoal();

        public abstract int RecordEvent();

        public abstract void DisplayGoalStatus();

        public abstract void SaveGoal(StreamWriter output);
#endregion
    }
}