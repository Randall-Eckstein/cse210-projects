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
            "What was the best part of the day?"
        };

        public List<string> prompt()
        {
            Console.WriteLine();
            Random rand = new Random();
            string prompt = prompts[rand.Next(0, this.prompts.Count())];
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            List<string> list = new List<string>() {prompt, response};
            return list;
        }
    }
}