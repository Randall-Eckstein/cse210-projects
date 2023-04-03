using System.Collections.Specialized;

namespace FinalProject
{
    public class Album : Media
    {
        private string _singer;

        private Dictionary<int, List<string>> _tracks;

        public Album()
        {
            this.CreateRecord();
        }

        public Album(string singer, Dictionary<int, List<string>> tracks, string title, int yearPublished, string genre, string date) : base(title, yearPublished, genre, date)
        {
            this._singer = singer;
            this._tracks = tracks;
        }

        public override void CreateRecord()
        {
            Console.Write("What is the name of the album: ");
            this.SetTitle(Console.ReadLine());

            Console.Write("Who is the lead singer or group: ");
            this._singer = Console.ReadLine();

            bool canContinue = false;
            this._tracks = new Dictionary<int, List<string>>();
            int track = 1;
            while (!canContinue)
            {
                Console.Write($"Enter the name of track {track} (type \"Done\" to finish): ");
                string response = Console.ReadLine();
                if (response.ToLower() != "done")
                {
                    this._tracks.Add(track, new List<string>() {"[ ]", response});
                    track++;
                }
                else
                {
                    canContinue = true;
                }
            }
            
            Console.Write("When was this album released: ");
            this.SetYear(int.Parse(Console.ReadLine()));
            
            Console.Write("What is the genre of this album: ");
            this.SetGenre(Console.ReadLine());
            Console.WriteLine();
        }

        public override string DisplayRecord()
        {
            return $"{this.GetCompleteString()} - {this.GetTitle()} by {this._singer}{this.GetDaysToComplete()}";
        }

        public void DisplayFullRecord()
        {
            Console.WriteLine($"{this.GetCompleteString()} - {this.GetTitle()} by {this._singer}{this.GetDaysToComplete()}");
            for (int i = 1; i <= this._tracks.Count(); i++)
            {
                Console.WriteLine($"\t{this._tracks[i][0]} - {i} - {this._tracks[i][1]}");
            }
        }

        public string GetSinger()
        {
            return this._singer;
        }
        public override void UpdateRecord()
        {
            for (int i = 1; i <= this._tracks.Count(); i++)
            {
                Console.WriteLine($"{i} - {this._tracks[i][1]}");
            }
            Console.WriteLine("Which track number did you listen to: ");
            int response = int.Parse(Console.ReadLine());
            this._tracks[response][0] = "[X]";

            Console.WriteLine();
            this.DisplayFullRecord();

            int tracksListenedTo = 0;
            foreach (var entry in this._tracks)
            {
                if (entry.Value[0] == "[X]")
                {
                    tracksListenedTo++;
                }
            }
            Console.WriteLine($"You have listened to {tracksListenedTo}/{this._tracks.Count()}");

            if (tracksListenedTo >= this._tracks.Count())
            {
                this.SetCompleteString();
                string days = this.SetDaysToComplete();
                Console.WriteLine($"Congratulations!  You finished listening to {this.GetTitle()} by {this._singer} in {days} days.");
            }
        }
    
        public override void SaveRecord(StreamWriter output)
        {
            string trackString = "";
            foreach (var track in this._tracks)
            {
                string index = track.Key.ToString();
                trackString += $"{track.Key.ToString()}+++{track.Value[0]}+++{track.Value[1]}||";
            }
            trackString = trackString.Remove(trackString.Length - 2);
            
            output.WriteLine($"Album::{this._singer}<+>{trackString}<+>{this.GetTitle()}<+>{this.GetYear()}<+>{this.GetGenre()}<+>{this.GetDate()}");
        }

    }
}