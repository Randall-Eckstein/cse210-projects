namespace Develop03
{
    public class Word
    {
        private string _word;

        // Checks a word to see if it can be modified.  If possible, sends the word to the succeeding function
        // Ignores integers, escaped new lines and indents, as well as words that have already been converted.
        public bool CanModify(string wordToCheck)
        {
            int tempInt = 0;
            if (int.TryParse(wordToCheck, out tempInt)) return false;
            else if (wordToCheck == "\n\n" || wordToCheck == "\n\t") return false;
            else if (wordToCheck[0] == '_' || (wordToCheck[0] == '\"' && wordToCheck[1] == '_')) return false;
            else
            {
                this.WordToUnderscore(wordToCheck);
                return true;
            }
        }

        private void WordToUnderscore(string wordToModify)
        {
            string tempWord = "";
            foreach (char letter in wordToModify)
            {
                if (letter == '\"')
                {
                    tempWord += '\"';
                }
                else
                {
                    tempWord += "_";
                }
            this._word = tempWord;
            }
        }

        public string GetWord()
        {
            return this._word;
        }
    }
}