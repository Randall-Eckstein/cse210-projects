namespace FinalProject
{
    public class Movie : Media
    {
        private string _director;
        private List<string> _actors;


        public Movie()
        {
            this.CreateRecord();
        }

        public Movie(string director, List<string> actors, string title, int yearPublished, string genre, string date) : base(title, yearPublished, genre, date)
        {
            this._director = director;
            this._actors = actors;
        }

        public override void CreateRecord()
        {
            Console.Write("What is the name of the movie: ");
            this.SetTitle(Console.ReadLine());

            Console.Write("Who is the director: ");
            this._director = Console.ReadLine();

            bool canContinue = false;
            this._actors = new List<string>();
            while (!canContinue)
            {
                Console.Write("Enter a name of a lead actor/actress (type \"Done\" to finish): ");
                string response = Console.ReadLine();
                if (response.ToLower() != "done")
                {
                    this._actors.Add(response);
                }
                else
                {
                    canContinue = true;
                }
            }
            
            Console.Write("When was this movie released: ");
            this.SetYear(int.Parse(Console.ReadLine()));
            
            Console.Write("What is the genre of this movie: ");
            this.SetGenre(Console.ReadLine());
            Console.WriteLine();
        }

        public override string DisplayRecord()
        {
            return $"{this.GetCompleteString()} - {this.GetTitle()} directed by {this._director} starring {this._actors[0]}\n";
        }

        public override void UpdateRecord()
        {
            this.SetCompleteString();
            string days = this.SetDaysToComplete();
            Console.WriteLine($"Congratulations, you finished watching {this.GetTitle()} directed by {this._director} starring {this._actors[0]}\n");
        }
    }
}