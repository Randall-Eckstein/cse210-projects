using System.Collections.Specialized;

namespace FinalProject
{
    public class Load : SaveLoad
    {
        public Load()
        {
            this.SetLocation();
        }

        public List<Media> GenerateList()
        {
            List<Media> freshList = new List<Media>(); 

            string[] lines = File.ReadAllLines(this.GetSaveLocation());

            foreach (string line in lines)
            {
                string[] breakdown = line.Split("::");
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
                        Dictionary<int, List<string>> tempDict = new Dictionary<int, List<string>>();
                        string[] trackParts = parts[1].Split("||");
                        foreach (string entity in trackParts)
                        {
                            string[] splitTrack = entity.Split("+++");
                            tempDict.Add(int.Parse(splitTrack[0]), new List<string>() {splitTrack[1], splitTrack[2]});
                        }

                        Album album = new Album(parts[0], tempDict, parts[2], int.Parse(parts[3]), parts[4], parts[5]);
                        freshList.Add(album);
                    break;
                    case "pageBook":
                        PageBook pageBook = new PageBook(parts[0], parts[1], int.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]));
                        freshList.Add(pageBook);
                    break;
                    case "chapterBook":
                        ChapterBook chapterBook = new ChapterBook(parts[0], parts[1], int.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]));
                        freshList.Add(chapterBook);
                    break;
                    default:
                    break;
                }
            }

            return freshList;
        }
    }
}