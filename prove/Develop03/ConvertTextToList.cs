namespace Develop03
{
    public class ConvertTextToList
    {
        public static List<string> textList;

        public ConvertTextToList()
        {
            textList = ScriptureList.scripture.Split(" ").ToList<string>();
        }
    }
}