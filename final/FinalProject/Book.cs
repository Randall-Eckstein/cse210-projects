namespace FinalProject
{
    public abstract class Book : Media
    {
        private string _author;

        public Book()
        {

        }

        public Book(string author, string title, int yearPublished, string genre, string date) : base(title, yearPublished, genre, date)
        {
            this._author = author;
        }
       
#region SharedMethods

        public void CreateBaseRecord()
        {
            Console.Write("What is the name of the book: ");
            this.SetTitle(Console.ReadLine());

            Console.Write("Who is the author: ");
            this._author = Console.ReadLine();
            
            Console.Write("When was this book published: ");
            this.SetYear(int.Parse(Console.ReadLine()));
            
            Console.Write("What is the genre of this book: ");
            this.SetGenre(Console.ReadLine());

        }

        public string GetAuthor()
        {
            return this._author;
        }

        public override string DisplayRecord()
        {
            return $"{this.GetCompleteString()} - {this.GetTitle()} by {this.GetAuthor()}{this.GetDaysToComplete()}";
        }

        public void CompleteMessage(string days)
        {
            Console.WriteLine($"Congratulations!  You finished {this.GetTitle()} by {this.GetAuthor()} in {days} days.");

        }

#endregion

#region AbstractMethods



#endregion
    }
}