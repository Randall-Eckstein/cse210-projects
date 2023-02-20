namespace Develop04
{
    public class Breathing : MindfulnessActivity
    {
        private int _durationOfPause;

        public Breathing(string activity, string description, int seconds) : base(activity, description)
        {
            this.SetDuration(seconds);
            this._durationOfPause = (int)(seconds/6);
            if (this._durationOfPause > 6)
            {
                this._durationOfPause = 6;
            }
            Console.WriteLine(this.SetStartupMessage(description));

            this.BreathingCountdown();
        }
        
        private void BreathingCountdown()
        {
            int secondsRemaining = this.GetDuration();
            Console.WriteLine($"\nWe will now practice your breathing for {secondsRemaining} seconds. Get ready in \n");
            this.StartingCountdown();

            while (secondsRemaining >= 0)
            {
                Console.WriteLine("\nBreathe In");
                this.RunAnimation(this._durationOfPause);
                Console.WriteLine("\nBreathe Out");
                this.RunAnimation(this._durationOfPause);
                secondsRemaining -= this._durationOfPause * 2;
            }

            this.GetConclusionMessage(this.GetDuration().ToString());
        }

    }
}