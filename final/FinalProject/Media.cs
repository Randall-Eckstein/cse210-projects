namespace FinalProject

{
    public abstract class Media
    {
        private string _title;
        private int _yearPublished;
        private string _complete = "[ ]";
        private DateTime _date;
        private string _daysToComplete = "";

        public Media()
        {
            this._date = DateTime.Now;
            Console.WriteLine(_date);
        }

        public Media(string title, int yearPublished, string date)
        {
            this._title = title;
            this._yearPublished = yearPublished;
            this._date = DateTime.Parse(date);
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

        public void SetDaysToComplete(int days)
        {
            this._daysToComplete = $" - {days.ToString()} days";
        }
#endregion


#region AbstractFunctions
        // Abstract Functions
        public abstract void CreateRecord();
        public abstract void UpdateRecord();
        public abstract void DisplayRecord();
#endregion
    }
}