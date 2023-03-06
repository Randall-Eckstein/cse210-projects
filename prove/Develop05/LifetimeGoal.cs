namespace Develop05
{
    public class LifetimeGoal : Goal
    {
        // Empty constructor used when creating a new goal
        public LifetimeGoal()
        {
            this.SetGoal();
        }

        // Constructor to set variables during load
        public LifetimeGoal(int pointValue, string goalName, string description, int timesCompleted) : base(pointValue, goalName, description)
        {
            this.SetTimesCompleted(timesCompleted);
        }

        public override void SetGoal()
        {
            this.SetCommonGoalDetails();
        }

        public override int RecordEvent()
        {
            this.IncreaseTimesCompleted();
            return this.GetPointValue();
        }

        public override void DisplayGoalStatus()
        {
            Console.WriteLine($"[ ] {this.GetGoalName()} ({this.GetGoalDescription()})");
        }

        public override void SaveGoal(StreamWriter output)
        {
            output.WriteLine($"Lifetime:{this.GetPointValue()}<+>{this.GetGoalName()}<+>{this.GetGoalDescription()}<+>{this.GetTimesCompleted()}");
        }
    }
}