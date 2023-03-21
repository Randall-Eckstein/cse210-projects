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

        public PageBook(string author, string genre, string title, int yearPublished, int totalPages, int completedPages, string date) : base(author, genre, title, yearPublished, date)
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
                int daysToComplete = (DateTime.Now - this.GetDate()).Days;
                this.SetDaysToComplete(daysToComplete);
                string title = this.GetTitle();
                string author = this.GetAuthor();
                this.CompleteMessage(daysToComplete);
                Console.WriteLine();
            }
        }
    }
}