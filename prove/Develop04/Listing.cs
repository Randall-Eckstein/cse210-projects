namespace Develop04
{
    public class Listing : MindfulnessActivity
    {

        private List<string> _listPrompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "Who are some of your personal heroes?",
            "When have you selflessly helped others?",
            "When have you given back to your community or friends?",
            "What are your best qualities?"
        };

        public Listing(string activity, string description, int duration) : base(activity, description)
        {
            this.SetDuration(duration);
            Console.WriteLine(this.SetStartupMessage(description));

            this.Prompt();
        }
        
        private void Prompt()
        {
            Random rand = new Random();
            Console.WriteLine($"\nYou will now have {this.GetDuration()} seconds to list as many responses to this prompt.\nGet ready in");
            this.StartingCountdown();
            Console.WriteLine("\n");
            Console.WriteLine(this._listPrompts[rand.Next(this._listPrompts.Count())]);
            this.RunAnimation(8);
            int listCount = this.ListAccumulator();
            Console.WriteLine($"Very good.  You wrote {listCount} items on your list.");
            this.GetConclusionMessage(this.GetDuration().ToString());
        }

        private int ListAccumulator()
        {
            Console.WriteLine("\nYou may begin writing your list now.");
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(this.GetDuration());
            int listCount = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string entry = Console.ReadLine();
                listCount ++;
            }
            return listCount;
        }
    }
}