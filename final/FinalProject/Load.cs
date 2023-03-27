using System.Collections.Specialized;

namespace FinalProject
{
    public class Load : SaveLoad
    {
        public Load()
        {
            this.SetLocation();
        }

        private List<Media> GenerateList()
        {
            List<Media> freshList = new List<Media>(); 

            string[] lines = File.ReadAllLines(this.GetSaveLocation());

            foreach (string line in lines)
            {
                string[] breakdown = line.Split(":");
                string type = breakdown[0];
                string[] parts = breakdown[1].Split("<+>");

                switch (type)
                {
                    case "Movie":
                        List<string> actors = parts[1].Split("+++").ToList<string>();
                        Movie movie = new Movie(parts[0], actors, parts[2], int.Parse(parts[3]), parts[4], parts[5]);
                        freshList.Add(movie);
                    break;
                    case "Album":
                        OrderedDictionary tempDict = new OrderedDictionary();
                        string[] trackParts = parts[1].Split("||");
                        foreach (string entity in trackParts)
                        {

                        }
                    break;
                    default:
                    break;
                }
            }

            return freshList;
        }
    }
}