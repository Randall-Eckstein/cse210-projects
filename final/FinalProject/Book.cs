namespace FinalProject
{
    public class Book : Media
    {
        private string _author;
        private string _genre;
        private bool _trackPages;
        private int _totalChapters;
        private int _completedChapters;
        private int _totalPages;
        private int _completedPages;

        public Book()
        {
            this.CreateRecord();
        }

        public Book(string author, string genre, int yearPublished, int totalChapters, int completedChapters, string title) : base(title, yearPublished)
        {
            this._author = author;
            this._genre = genre;
            this._totalChapters = totalChapters;
            this._completedChapters = completedChapters;
            this._trackPages = true;
        }

        public Book(string author, string genre, int yearPublished, int totalPages, int completedPages, string title) : base(title, yearPublished)
        {
            this._author = author;
            this._genre = genre;
            this._totalPages = totalPages;
            this._completedPages = completedPages;
            this._trackPages = false;
        }
       
       public void CreateRecord()
       {
            Console.Write("What is the name of the book: ");
            this.SetTitle(Console.ReadLine());
            Console.Write("Who is the author: ");
            this._author = Console.ReadLine();
            Console.Write("When was this book published: ");
            this.SetYear(Console.ReadLine());
            Console.Write("What is the genre of this book: ")
            this._genre = Console.ReadLine();
            Console.Write("Would you like to track your progress by chapter or by page? Type \"Chapter\" or \"Page\": ");
            string track = Console.ReadLine().ToLower();
            if (track.startsWith("c"))
            {
                this._trackPages = false;
                Console.Write("How many chapters are in this book: ");
                this._totalChapters = int.Parse(Console.ReadLine());
            }
            else if (track.startsWith("p"))
            {
                this._trackPages = true;
                Console.Write("How many chapters are in this book: ");
                this._totalPages = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid choice.  Will default to tracking by number of pages.")
                this._trackPages = true;
                Console.Write("How many chapters are in this book: ");
                this._totalPages = int.Parse(Console.ReadLine());

            }

       }
    }
}