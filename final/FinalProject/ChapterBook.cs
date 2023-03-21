namespace FinalProject
{
    public class ChapterBook : Book
    {
        private int _totalChapters;
        private int _completedChapters;

        public ChapterBook()
        {
            this.CreateBaseRecord();
            this.CreateRecord();
        }

        public ChapterBook(string author, string genre, string title, int yearPublished, int totalChapters, int completedChapters, string date) : base(author, genre, title, yearPublished, date)
        {
            this._totalChapters = totalChapters;
            this._completedChapters = completedChapters;
        }

        public override void CreateRecord()
        {
            Console.Write("How many chapters are in this book: ");
            this._totalChapters = int.Parse(Console.ReadLine());
            this._completedChapters = 0;
            Console.WriteLine();
        }

        public override void UpdateRecord()
        {
            int completed = 0;
            bool canContinue = false;
            while (!canContinue)
            {
                Console.Write("How many chapters did you read: ");
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

            this._completedChapters = completed;

            int difference = this._totalChapters - this._completedChapters;

            if (difference > 0)
            {
                Console.WriteLine($"Great job!  You have only {difference} chapters left!\n");
            }
            else
            {
                this.SetCompleteString();
                int daysToComplete = (DateTime.Now - this.GetDate()).Days;
                this.SetDaysToComplete(daysToComplete);
                this.CompleteMessage(daysToComplete);
                Console.WriteLine();
            }
        }
    }
}