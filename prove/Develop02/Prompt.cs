namespace Develop02
{
    public class Prompt
    {
        List<string> prompts = new List<string>()
        {
            "What did you do today that was interesting?",
            "If you could have done one thing differently today, what would it have been?",
            "Who did you meet today that was most meaningful?",
            "How did you recognize God in your life today?",
            "How did the weather impact your day?",
            "What was the best part of the day?",
            "Where did you go that was most interesting or noteworthy?",
            "What did you do today that was out of the ordinary?",
            "Were you able to do something to help others today?  If not, what would you like to do tomorrow?",
            "How could your day have been better?",
            "What blessings did you see in your life today?",
            "When did you pause and remember who you are or what you stand for today?"
        };

        public Entry PromptGenerator()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine();
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string prompt = prompts[rand.Next(0, this.prompts.Count())];
            Console.WriteLine(prompt);
            Console.ForegroundColor = ConsoleColor.Green;
            string response = Console.ReadLine();
            string currentDate = date.ToShortDateString();
            Entry entry = new Entry(currentDate, prompt, response);
            Console.ForegroundColor = ConsoleColor.White;
            return entry;
        }
    }
}