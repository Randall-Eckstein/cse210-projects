namespace Develop04
{
    public class MindfulnessActivity
    {
        private int _activityDuration;
        private string _startUpMessage;
        private string _conclusion;
        private string _activityName;

        private int milliseconds = 125;

        public MindfulnessActivity(string activity, string description)
        {
            this._activityName = activity;
            this._startUpMessage = SetStartupMessage(description);
        }

        public string SetStartupMessage(string description)
        {
            string newMessage = $"\nThis activity will help you {description}";
            return newMessage;
        }

        public void GetConclusionMessage(string time)
        {
            this._conclusion = $"\nCongratulations.  You spent {this._activityDuration} seconds on {this._activityName}.  Continue to embrace the mindfulness and melt your cares away.";
            Console.WriteLine(this._conclusion);
            Console.WriteLine("\nPress <Enter> to continue.");
            Console.ReadLine();
        }

        public void SetDuration(int time)
        {
            this._activityDuration = time;
        }

        public int GetDuration()
        {
            return this._activityDuration;
        }

        public void RunAnimation(float seconds)
        {
            float timeRemaining = seconds;

            while (timeRemaining >= 0)
            {
                Console.Write("\b \b/");
                Thread.Sleep(milliseconds);
                Console.Write("\b \b—");
                Thread.Sleep(milliseconds);
                Console.Write("\b \b\\");
                Thread.Sleep(milliseconds);
                Console.Write("\b \b|");
                Thread.Sleep(milliseconds);
                timeRemaining -= 0.5f;
            }
            Console.Write("\b \b");
        }

        public void StartingCountdown()
        {
            Console.Write("\b \b5");
            Thread.Sleep(500);
            Console.Write("\b \b4");
            Thread.Sleep(500);
            Console.Write("\b \b3");
            Thread.Sleep(500);
            Console.Write("\b \b2");
            Thread.Sleep(500);
            Console.Write("\b \b1");
            Thread.Sleep(500);
            Console.Write("\b \bBegin");
            Thread.Sleep(250);
        }

    }
}