namespace Develop05
{
    public class ChecklistGoal : Goal
    {
        private int _timesToCompletion;
        private int _bonusPoints;

        // Empty constructor for new goal
        public ChecklistGoal()
        {
            this.SetGoal();
        }

        // Constructor with parameters for loading
        public ChecklistGoal(int pointValue, string goalName, string description, int bonusPoints, int timesToCompletion, int timesCompleted) : base(pointValue, goalName, description)
        {
            this._bonusPoints = bonusPoints;
            this._timesToCompletion = timesToCompletion;
            this.SetTimesCompleted(timesCompleted);
        }

        public override void SetGoal()
        {
            this.SetCommonGoalDetails();

            bool canContinueTimes = false;
            int times = 0;
            while (!canContinueTimes)
            {
                try
                {
                    Console.WriteLine("How many times does this goal need to be completed for a bonus? ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    times = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    canContinueTimes = true;
                }
                catch (FormatException)
                {
                    Console.Write("Sorry, I didn't get that.  Please try again.");
                }
            }
            this._timesToCompletion = times;

            bool canContinueBonus = false;
            int bonus = 0;
            while (!canContinueBonus)
            {
                try
                {
                    Console.WriteLine($"How many points will be awarded after completing the goal {this._timesToCompletion} times? ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    bonus = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    canContinueBonus = true;
                }
                catch (FormatException)
                {
                    Console.Write("Sorry, I didn't get that.  Please try again.");
                }
            }
            this._bonusPoints = bonus;
        }

        public override int RecordEvent()
        {
            this.IncreaseTimesCompleted();
            int pointsToGrant = 0;
            if (this._timesToCompletion % this.GetTimesCompleted() != 0)
            {
                pointsToGrant = this.GetPointValue();
            }
            else
            {
                pointsToGrant = this.GetPointValue() + this._bonusPoints;
            }
            return pointsToGrant;
        }

        public override void DisplayGoalStatus()
        {
            string completionStatus = "[ ]";
            if (this.GetTimesCompleted() >= this._timesToCompletion)
            {
                completionStatus = "[X]";
            }

            Console.WriteLine($"{completionStatus} {this.GetGoalName()} ({this.GetGoalDescription()}) -- Completed {this.GetTimesCompleted()}/{this._timesToCompletion}");
        }
    
        public override void SaveGoal(StreamWriter output)
        {
            output.WriteLine($"Checklist:{this.GetPointValue()}<+>{this.GetGoalName()}<+>{this.GetGoalDescription()}<+>{this._bonusPoints}<+>{this._timesToCompletion}<+>{this.GetTimesCompleted()}");
        }
}
}