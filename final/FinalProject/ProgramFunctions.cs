namespace FinalProject
{
    public class ProgramFunctions
    {
        ChapterBook book1 = new ChapterBook();

        PageBook book2 = new PageBook();

        public void RunProgram()
        {
            this.book1.UpdateRecord();
            this.book2.UpdateRecord();
            this.book1.DisplayRecord();
            this.book2.DisplayRecord();
        }







            // Console.Write("Would you like to track your progress by chapter or by page? Type \"Chapter\" or \"Page\": ");
            // string track = Console.ReadLine().ToLower();
            // if (track.StartsWith("c"))
            // {
            //     this._trackPages = false;
            //     Console.Write("How many chapters are in this book: ");
            //     this._totalChapters = int.Parse(Console.ReadLine());
            // }
            // else if (track.StartsWith("p"))
            // {
            //     this._trackPages = true;
            //     Console.Write("How many chapters are in this book: ");
            //     this._totalPages = int.Parse(Console.ReadLine());
            // }
            // else
            // {
            //     Console.WriteLine("Sorry, that is not a valid choice.  Will default to tracking by number of pages.");
            //     this._trackPages = true;
            //     Console.Write("How many chapters are in this book: ");
            //     this._totalPages = int.Parse(Console.ReadLine());
            // }

    }
}