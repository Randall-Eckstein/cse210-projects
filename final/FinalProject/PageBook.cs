namespace FinalProject
{
    public class PageBook : Book
    {
        private int _totalPages;
        private int _completedPages;

        public PageBook()
        {
            this.CreateBaseRecord();
            this.CreateRecord();
        }

        public PageBook(string author, string title, int yearPublished, string genre, string date, int totalPages, int completedPages) : base(author, title, yearPublished, genre, date)
        {
            this._totalPages = totalPages;
            this._completedPages = completedPages;
        }

        public override void CreateRecord()
        {
            Console.Write("How many pages are in this book: ");
            this._totalPages = int.Parse(Console.ReadLine());
            this._completedPages = 0;
            Console.WriteLine();
        }

        public override void UpdateRecord()
        {
            int completed = 0;
            bool canContinue = false;
            while (!canContinue)
            {
                Console.Write("How many pages did you read: ");
                try
                {
                    completed = int.Parse(Console.ReadLine());
                    canContinue = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry, that is not a valid number.  Please try again.");
                }
            }

            this._completedPages = completed;

            int difference = this._totalPages - this._completedPages;

            if (difference > 0)
            {
                Console.WriteLine($"Great job!  You have only {difference} pages left!");
            }
            else
            {
                this.SetCompleteString();
                string daysToComplete = this.SetDaysToComplete();
                string title = this.GetTitle();
                string author = this.GetAuthor();
                this.CompleteMessage(daysToComplete);
                Console.WriteLine();
            }
        }
    
        public override void SaveRecord(StreamWriter output)
        {
            // public PageBook(string author, string title, int yearPublished, string genre, string date, int totalPages, int completedPages) : base(author, title, yearPublished, genre, date)
            // output.WriteLine($"Lifetime:{this.GetPointValue()}<+>{this.GetGoalName()}<+>{this.GetGoalDescription()}<+>{this.GetTimesCompleted()}");

            throw new NotImplementedException();
        }
    }
}