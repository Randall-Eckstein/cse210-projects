namespace FinalProject
{
    public class Save : SaveLoad
    {
        private List<Media> _media;

        public Save(List<Media> media)
        {
            this._media = media;
            this.SetLocation();
        }

        public void SaveEntries()
        {
            using (StreamWriter outputFile = new StreamWriter(this.GetSaveLocation()))
            {
                foreach (Media entry in this._media)
                {
                    entry.SaveRecord(outputFile);
                }
            }
        }
    }
}