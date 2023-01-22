using System.IO;

namespace Develop02
{
    public class Display
    {
        public void display(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }
        }
    }
}