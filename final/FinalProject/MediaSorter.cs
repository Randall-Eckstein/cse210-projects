namespace FinalProject
{
    public class MediaSorter
    {
        private List<Media> _fullList;

        private List<Media> _movieList;
        private List<Media> _bookList;
        private List<Media> _albumList;

        private List<Media> _sortedList;

        public MediaSorter(List<Media> media)
        {
            this._fullList = media;
            this._movieList = new List<Media>();
            this._bookList = new List<Media>();
            this._albumList = new List<Media>();
            this._sortedList = new List<Media>();

            foreach (Media entity in this._fullList)
            {
                if (entity.GetType() == typeof(Movie))
                {
                    this._movieList.Add(entity);
                }
                else if (entity.GetType() == typeof(ChapterBook))
                {
                    this._bookList.Add(entity);
                }
                else if (entity.GetType() == typeof(PageBook))
                {
                    this._bookList.Add(entity);
                }
                else if (entity.GetType() == typeof(Album))
                {
                    this._albumList.Add(entity);
                }
                else
                {
                    Console.WriteLine($"{entity.GetTitle()} is not a movie, book, or album.");
                }
            }
            this.MainMenu();
        }

        public void MainMenu()
        {
            Console.Write("" +
"What would you like to search by? \n" +
"\t1. Movie Director\n" +
"\t2. Movie Actor/Actress\n" +
"\t3. Movie genre\n" +
"\t4. Movie year produced\n" +
"\t5. Book Author\n" +
"\t6. Book genre\n" +
"\t7. Book year published\n" +
"\t8. Album Singer/Band\n" +
"\t9. Album genre\n" +
"\t10. Album year produced\n" +
"Type a number to choose: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("What is the director's name: ");
                    string director = Console.ReadLine();
                    this.DirectorSort(director);
                break;

                case 2:
                    Console.Write("What is the actor's/actress's name: ");
                    string actor = Console.ReadLine();
                    this.SortActor(actor);
                break;

                case 3:
                    Console.Write("What is the movie genre: ");
                    string movieGenre = Console.ReadLine();
                    this.MovieGenre(movieGenre);
                break;

                case 4:
                    List<int> mYears = this.YearQuery();
                    this.MovieYear(mYears[0], mYears[1]);
                break;

                case 5:
                    Console.Write("What is the author's name: ");
                    string author = Console.ReadLine();
                    this.AuthorSort(author);
                break;

                case 6:
                    Console.Write("What is the book genre: ");
                    string bookGenre = Console.ReadLine();
                    this.BookGenre(bookGenre);
                break;

                case 7:
                    List<int> bYears = this.YearQuery();
                    this.BookYear(bYears[0], bYears[1]);
                break;

                case 8:
                    Console.Write("What is the singer/band's name: ");
                    string singer = Console.ReadLine();
                    this.SingerSort(singer);
                break;

                case 9:
                    Console.Write("What is the album genre: ");
                    string albumGenre = Console.ReadLine();
                    this.AlbumGenre(albumGenre);
                break;

                case 10:
                    List<int> aYears = this.YearQuery();
                    this.AlbumYear(aYears[0], aYears[1]);
                break;

                default:
                break;
            }
        }

        private List<int> YearQuery()
        {
            Console.WriteLine("Please type two years, a beginning and an end, to search through (ex. 1996 - 2000)");
            Console.Write("Beginning year: ");
            int early = int.Parse(Console.ReadLine());
            Console.Write("Ending year: ");
            int late = int.Parse(Console.ReadLine());

            return new List<int>() {early, late};
        }

        private void DisplaySortedList()
        {
            if (this._sortedList.Count() > 0)
            {
                foreach (Media entity in this._sortedList)
                {
                    Console.WriteLine(entity.DisplayRecord());
                }

            }
            else
            {
                Console.WriteLine("No items found that fit within that criteria.");
            }
        }

        private void AlbumYear(int v1, int v2)
        {
            foreach (Album album in this._albumList)
            {
                if ((v1 - album.GetYear()) * (album.GetYear() - v2) >= 0)
                    _sortedList.Add(album);
            }

            this.DisplaySortedList();
        }

        private void AlbumGenre(string albumGenre)
        {
            foreach (Album album in this._albumList)
            {
                if (album.GetGenre().ToLower() == albumGenre.ToLower()) this._sortedList.Add(album);
            }

            this.DisplaySortedList();
        }

        private void SingerSort(string singer)
        {
            foreach (Album album in this._albumList)
            {
                if (album.GetSinger().ToLower() == singer.ToLower()) this._sortedList.Add(album);
            }

            this.DisplaySortedList();
        }

        private void BookYear(int v1, int v2)
        {
            foreach (Book book in this._bookList)
            {
                if ((v1 - book.GetYear()) * (book.GetYear() - v2) >= 0)
                _sortedList.Add(book);
            }

            this.DisplaySortedList();
        }

        private void BookGenre(string bookGenre)
        {
            foreach (Book book in this._bookList)
            {
                if (book.GetGenre().ToLower() == bookGenre.ToLower()) this._sortedList.Add(book);
            }

            this.DisplaySortedList();
        }

        private void AuthorSort(string author)
        {
            foreach (Book book in this._bookList)
            {
                if (book.GetAuthor().ToLower() == author.ToLower()) this._sortedList.Add(book);
            }

            this.DisplaySortedList();
        }

        private void MovieYear(int v1, int v2)
        {
            foreach (Movie movie in this._movieList)
            {
                if ((v1 - movie.GetYear()) * (movie.GetYear() - v2) >= 0)
                _sortedList.Add(movie);
            }

            this.DisplaySortedList();
        }

        private void MovieGenre(string movieGenre)
        {
            foreach (Movie movie in this._movieList)
            {
                if (movie.GetGenre().ToLower() == movieGenre.ToLower()) this._sortedList.Add(movie);
            }

            this.DisplaySortedList();
        }

        private void SortActor(string actor)
        {
            foreach (Movie movie in this._movieList)
            {
                if (movie.GetActors().Contains(actor)) this._sortedList.Add(movie);
            }

            this.DisplaySortedList();
        }

        private void DirectorSort(string director)
        {
            foreach (Movie movie in this._movieList)
            {
                if (movie.GetDirector().ToLower() == director.ToLower()) this._sortedList.Add(movie);
            }

            this.DisplaySortedList();
        }
    }
}