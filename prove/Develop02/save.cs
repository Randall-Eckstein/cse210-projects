using System.IO;

namespace Develop02
{
    public class Save
    {
        public void save(string prompt, string content)
        {
            Console.Write($"Current filename is {Program.filename}\n\tDo you wish to continue using this? Y/N: ");
            string choice = Console.ReadLine();
            if (char.ToLower(choice[0]) == 'n')
            {
                Load load = new Load();
                Program.filename = load.load();
            }
            

            DateTime date = DateTime.Now;
            using (StreamWriter newFile = new StreamWriter(Program.filename, true))
            {
                newFile.WriteLine($"Date: {date.ToShortDateString()} - Prompt: {prompt}");
                newFile.WriteLine(content);
                newFile.WriteLine();
            }
        }
    }
}