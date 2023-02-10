namespace Develop03
{
    public class UpdateList
    {
        Random _rand = new Random();
        private Word word = new Word();

        // Iterates over the list a number of times
        // Uses a random index to select a word to pass to the Word class.
        public void ListUnderscore(int runs)
        {
            for (int i = 0; i < runs; i++)
            {
                bool canModify = false;
                while (!canModify)
                {
                    int randomIndex = this._rand.Next(ConvertTextToList.textList.Count());
                    canModify = this.word.CanModify(ConvertTextToList.textList[randomIndex]);
                    if (canModify)
                    {
                        ConvertTextToList.textList[randomIndex] = this.word.GetWord();
                    }
                }
            }
        }
    }
}