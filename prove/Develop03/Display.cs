namespace Develop03
{
    public class Display
    {
        private bool _canQuit = false;
        private UpdateList _update =  new UpdateList();
        
        // Display List is the main function.  It will first display the unedited text of the scripture.
        // After the first iteration, it will continue to display the updated list.
        public void DisplayList()
        {
            this.Concatenate();
            while (!this._canQuit)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nTo continue, press the enter key.  Type \"Quit\" to quit.");
                string response = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (response == "")
                {
                    Console.Clear();
                    int wordsToUpdate = this.VerifyCompletion();
                    if (wordsToUpdate == 0)
                    {
                        this._canQuit = true;
                        break;
                    }
                    else if (wordsToUpdate >= 3)
                    {
                        this._update.ListUnderscore(3);
                    }
                    else
                    {
                        this._update.ListUnderscore(wordsToUpdate);
                    }
                    this.Concatenate();
                }
                else if (response.ToLower() == "quit")
                {
                    _canQuit = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, that is not a valid input.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        
        private void Concatenate()
        {
            string concatenatedList = "";
            foreach (string item in ConvertTextToList.textList)
            {
                concatenatedList += $"{item} ";
            }
            Console.WriteLine($"\n{Reference.verse}\n{concatenatedList}");
        }

        // parses the first or second index of each string in the list of words.
        // Returns an int value of how many words remain unchanged.
        private int VerifyCompletion()
        {
            int unmodifiedWords = 0;
            foreach (string item in ConvertTextToList.textList)
            {
                int tempInt = 0;
                if (int.TryParse(item, out tempInt)) continue;
                else if (item == "\n\n" || item == "\n\t") continue;
                else if (item[0] == '_' || (item[0] == '\"' && item[1] == '_')) continue;
                else unmodifiedWords += 1;
            }
            if (unmodifiedWords <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Congratulations!  This scripture has been completed.\n\n");
                return 0;
            }
            return unmodifiedWords;
        }
    }
}