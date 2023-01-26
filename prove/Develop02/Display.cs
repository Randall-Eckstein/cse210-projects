using System.IO;

namespace Develop02
{
    public class Display
    {
        public void DisplayJournal(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            int counter = 0;
            foreach (string item in lines)
            {
                if (counter % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (counter % 3 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine(item);
                counter++;
            }
        }
    }
}