namespace Develop02
{
    public class Load
    {
        public string load()
        {
            Console.Write("What filename would you like to use? ");
            string file = Console.ReadLine();
            return $"D://{file}.txt";
        }
    }
}