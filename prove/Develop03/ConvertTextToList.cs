namespace Develop03
{
    public class ConvertTextToList
    {
        public static List<string> textList;

        public ConvertTextToList()
        {
            textList = Reference.scripture.Split(" ").ToList<string>();
        }
    }
}