namespace FinalProject
{
    public class SaveLoad
    {
        private string saveLocation = "myMedia.txt";

        public void SetLocation()
        {
            Console.Write($"Current save file is {this.saveLocation}.  Would you like to keep this location? (y/n): ");
            string response = Console.ReadLine().ToLower();

            if (response.StartsWith("n"))
            {
                bool canContinue = false;
                while (!canContinue)
                {
                    try
                    {
                        Console.Write("Got it.  What file name would you like to save (ex. myMedia.txt): ");
                        this.saveLocation = Console.ReadLine();
                        if (this.saveLocation.Substring(this.saveLocation.Length - 4) != ".txt")
                        {
                            throw new FormatException("Sorry, that will not work as a save file.");
                        }
                        canContinue = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"A valid filename must end with \".txt\"; your filename ended with {this.saveLocation.Substring(this.saveLocation.Length - 4)}\nPlease try again.");
                    }
                }
            }
        }

        public string GetSaveLocation()
        {
            return this.saveLocation;
        }
    }
}