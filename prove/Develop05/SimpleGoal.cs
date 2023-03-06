namespace Develop05
{
    public class SimpleGoal : Goal
    {
        private bool _completed;

        // Empty constructor for creating a new goal
        public SimpleGoal()
        {
            this._completed = false;
            this.SetGoal();
        }

        // Constructor with parameters for loading
        public SimpleGoal(int pointValue, string goalName, string description, bool completed) : base(pointValue, goalName, description)
        {
            this._completed = completed;
        }

        public override void SetGoal()
        {
            this.SetCommonGoalDetails();
        }

        public override int RecordEvent()
        {
            this._completed = true;
            return this.GetPointValue();
        }

        public override void DisplayGoalStatus()
        {
            string completionStatus = "[ ]";
            if (this._completed)
            {
                completionStatus = "[X]";
            }
            Console.WriteLine($"{completionStatus} {this.GetGoalName()} ({this.GetGoalDescription()})");
        }

        public override void SaveGoal(StreamWriter output)
        {
            output.WriteLine($"Simple:{this.GetPointValue()}<+>{this.GetGoalName()}<+>{this.GetGoalDescription()}<+>{this._completed}");
        }
    }
}