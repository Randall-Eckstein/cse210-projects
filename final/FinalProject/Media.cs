namespace FinalProject

{
    public abstract class Media
    {
        private string _title;
        private int _yearPublished;
        private string _complete = "[ ]";
        private DateTime _date;
        private string _daysToComplete = "";
        private string _genre;

        public Media()
        {
            this._date = DateTime.Now;
            Console.WriteLine(_date);
        }

        public Media(string title, int yearPublished, string genre, string date)
        {
            this._title = title;
            this._yearPublished = yearPublished;
            this._date = DateTime.Parse(date);
            this._genre = genre;
        }

#region SharedFunctions
        // Shared Functions

        public string GetTitle()
        {
            return this._title;
        }

        public void SetTitle(string title)
        {
            this._title = title;
        }

        public int GetYear()
        {
            return this._yearPublished;
        }

        public void SetYear(int yearPublished)
        {
            this._yearPublished = yearPublished;
        }

        public string GetCompleteString()
        {
            return this._complete;
        }

        public void SetCompleteString()
        {
            this._complete = "[X]";
        }

        public DateTime GetDate()
        {
            return this._date;
        }

        public string GetDaysToComplete()
        {
            return this._daysToComplete;
        }

        public string SetDaysToComplete()
        {
            string days = (DateTime.Now - this.GetDate()).Days.ToString();
            this._daysToComplete = $" - {days} days";
            return days;
        }

        public string GetGenre()
        {
            return this._genre;
        }

        public void SetGenre(string genre)
        {
            this._genre = genre;
        }
#endregion


#region AbstractFunctions
        // Abstract Functions
        public abstract void CreateRecord();
        public abstract void UpdateRecord();
        public abstract string DisplayRecord();
        public abstract void SaveRecord(StreamWriter output);
#endregion
    }
}