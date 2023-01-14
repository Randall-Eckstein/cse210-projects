namespace Learning02
{
    public class Job
    {

        public string _company { get; private set; }
        public string _jobTitle { get; private set; }
        public int _startYear { get; private set; }
        public int _endYear { get; private set; }

        public Job(string company, string title, int start, int end)
        {
            this._company = company;
            this._jobTitle = title;
            this._startYear = start;
            this._endYear = end;    
        }

        public void Display()
        {
            if (_endYear == 0)
            {
                Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-current");
            }
            else
            {
                Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
            }
        }
    }
}