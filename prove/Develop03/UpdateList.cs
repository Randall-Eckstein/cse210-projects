namespace Develop03
{
    public class UpdateList
    {
        Random _rand = new Random();

        // Iterates over the list a number of times
        // Uses a random index to attempt to convert string to underscore.
        // Ignores integers, escaped new lines and indents, as well as words that have already been converted.
        public void ListUnderscore(int runs)
        {
            for (int i = 0; i < runs; i++)
            {
                bool canModify = false;
                while (!canModify)
                {
                    int randomIndex = this._rand.Next(ConvertTextToList.textList.Count());
                    string tempWord = ConvertTextToList.textList[randomIndex];
                    int tempInt = 0;
                    if (int.TryParse(tempWord, out tempInt)) continue;
                    else if (tempWord == "\n\n" || tempWord == "\n\t") continue;
                    else if (tempWord[0] == '_' || (tempWord[0] == '\"' && tempWord[1] == '_')) continue;
                    else
                    {
                        string newTempWord = "";
                        foreach (char letter in tempWord)
                        {
                            if (letter == '\"')
                            {
                                newTempWord += '\"';
                            }
                            else
                            {
                                newTempWord += "_";
                            }
                        }
                        ConvertTextToList.textList[randomIndex] = newTempWord;
                        canModify = true;
                    }
                }
            }
        }
    }
}