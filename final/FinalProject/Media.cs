namespace FinalProject

{
    public abstract class Media
    {
        private string _title;
        private int _yearPublished;

        public Media()
        {
            
        }

        public Media(string title, int yearPublished)
        {
            this._title = title;
            this._yearPublished = yearPublished;
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
#endregion


#region AbstractFunctions
        // Abstract Functions
        public abstract void CreateRecord;

#endregion
    }
}