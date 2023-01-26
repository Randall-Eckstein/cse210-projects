namespace Develop02
{
    public class Entry
    {
        public string _date { get; set; }
        public string _prompt { get; set; }
        public string _response { get; set; }

        public Entry(string date, string prompt, string response)
        {
            this._date = date;
            this._prompt = prompt;
            this._response = response;
        }
    }
}