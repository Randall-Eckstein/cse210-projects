namespace FinalProject
{
    public class ProgramFunctions
    {
        private bool canContinue = true;
        private List<Media> _media = new List<Media>();

        public void RunProgram()
        {
            Console.WriteLine("Welcome to the media tracker");
            while (canContinue)
            {
                Console.WriteLine();
                Console.Write(
"\t1. Track a new Book\n" +
"\t2. Track a new Movie\n" +
"\t3. Track a new Album\n" +
"\t4. Update a Media Record\n" +
"\t5. Display all media\n" +
"\t6. Load from file\n" +
"\t7. Save to file\n" +
"\t8. Sort Media\n" +
"\t9. Quit\n" +
"What would you like to do today: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Would you like to track your progress by chapter or by page? Type \"Chapter\" or \"Page\": ");
                        string track = Console.ReadLine().ToLower();
                        if (track.StartsWith("c"))
                        {
                            ChapterBook cBook = new ChapterBook();
                            this._media.Add(cBook);
                        }
                        else if (track.StartsWith("p"))
                        {
                            PageBook pBook = new PageBook();
                            this._media.Add(pBook);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that is not a valid choice.  Will default to tracking by number of pages.");
                            PageBook pBook = new PageBook();
                            this._media.Add(pBook);
                        }
                    break;
                    
                    case 2:
                        Movie movie = new Movie();
                        this._media.Add(movie);
                    break;
                    
                    case 3:
                        Album album = new Album();
                        this._media.Add(album);
                    break;
                    
                    case 4:
                        int counter = 1;
                        foreach (Media entry in this._media)
                        {
                            Console.WriteLine($"{counter}. {entry.DisplayRecord()}");
                            counter ++;
                        }
                        Console.WriteLine();
                        bool canProceed = false;
                        int selection = 0;
                        while (!canProceed)
                        {
                            try
                            {
                                Console.Write("Which entry would you like to update: ");
                                selection = int.Parse(Console.ReadLine()) - 1;
                                if (selection >= this._media.Count()) throw new IndexOutOfRangeException("Sorry, I don't have that entry in my system.");
                                canProceed = true;
                            }
                            catch
                            {
                                Console.WriteLine("Sorry, that is not a valid choice.  Please try again.");
                            }
                        }
                        this._media[selection].UpdateRecord();
                    break;

                    case 5:
                        foreach (Media entry in this._media)
                        {
                            Console.WriteLine(entry.DisplayRecord());
                        }
                        Console.WriteLine();
                    break;
                    
                    case 6:
                        Load load = new Load();
                        this._media = load.GenerateList();
                    break;
                    
                    case 7:
                        Save save1 = new Save(this._media);
                        save1.SaveEntries();
                    break;
                    
                    case 8:
                        MediaSorter sorter = new MediaSorter(this._media);
                    break;

                    case 9:
                        Console.WriteLine("Now quitting the media tracker.");
                        this.canContinue = false;
                    break;

                    default:
                    break;
                }
            }
        }


    }
}