namespace Develop04
{
    public class Reflecting : MindfulnessActivity
    {
        private List<string> _reflectingQuestions = new List<string>() 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you walked in someone else's shoes.",
            "Think of a time when you got some unexpected help."
        };

        private List<string> _prompts = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private List<int> _questionIndexes;

        private List<int> _promptIndexes;

        private Random _rand = new Random();

        public Reflecting(string activity, string description, int duration) : base(activity, description)
        {
            this.SetIndexes();
            this.SetDuration(duration);
            Console.WriteLine(this.SetStartupMessage(description));

            this.RunReflection();
        }


        private void SetIndexes()
        {
            this._promptIndexes = new List<int>();
            this._questionIndexes = new List<int>();

            for (int i = 0; i < this._reflectingQuestions.Count(); i++)
            {
                this._questionIndexes.Add(i);
            }

            for (int j = 0; j < this._prompts.Count(); j++)
            {
                this._promptIndexes.Add(j);
            }

        }
    
        private void RunReflection()
        {
            int secondsRemaining = this.GetDuration();

            Console.WriteLine($"You will now be shown a question to reflect on.  You will have {this.GetDuration()} seconds to reflect.  Prompts will be given to help you ponder the moments.\n\nGet ready in ");
            this.StartingCountdown();
            
            Console.WriteLine();
            Console.WriteLine(this.ChooseRandomQuestion());
            Thread.Sleep(1000);

            while (secondsRemaining >= 0)
            {
                Console.WriteLine();
                Console.WriteLine(this.ChooseRandomPrompt());
                this.RunAnimation(10);
                secondsRemaining -= 10;
            }

            this.GetConclusionMessage(this.GetDuration().ToString());
        }

        private string ChooseRandomQuestion()
        {
            int index = this._questionIndexes[_rand.Next(this._questionIndexes.Count())];
            string question = this._reflectingQuestions[index];
            this._questionIndexes.Remove(index);
            return question;
        }

        private string ChooseRandomPrompt()
        {
            int index = this._promptIndexes[_rand.Next(this._promptIndexes.Count())];
            string prompt = $"{index} - {this._prompts[index]}";
            this._promptIndexes.Remove(index);
            if (this._promptIndexes.Count() == 0)
            {
                this.SetIndexes();
            }
            return prompt;
        }
    
    }
}