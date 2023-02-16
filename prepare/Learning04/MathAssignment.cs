namespace Learning04
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public MathAssignment(string textbookSection, string problems, string studentName, string topic) : base(studentName, topic)
        {
            this._textbookSection = textbookSection;
            this._problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"Section {this._textbookSection} Problems {this._problems}";
        }
    }
}