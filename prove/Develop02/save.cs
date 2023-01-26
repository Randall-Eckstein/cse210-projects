using System.IO;

namespace Develop02
{
    public class SaveLoad
    {
        public void SaveEntries()
        {
            bool saveFile = false;
            while (!saveFile)
            {
                Console.Write($"Current filename is {Program.filename}\n\tDo you wish to continue using this? Y/N: ");
                string choice = Console.ReadLine();
                try 
                {
                    if (char.ToLower(choice[0]) == 'n')
                    {
                        Load load = new Load();
                        Program.filename = this.LoadEntries();
                    }
                    saveFile = true;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sorry, please choose Y or N.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            
            using (StreamWriter newFile = new StreamWriter(Program.filename, true))
            {
                foreach (Entry entry in Program.entries){
                    newFile.WriteLine($"{entry._date} - {entry._prompt}");
                    newFile.WriteLine(entry._response);
                    newFile.WriteLine();
                };

                Program.entries.Clear();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Save complete.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public string LoadEntries()
        {
            Console.Write("What filename would you like to use? ");
            string file = Console.ReadLine();
            return $"D://{file}.txt";
        }

    }
}