namespace First_Project.Models
{
    internal class Album: IReview
    {
        private List<Song> songs = new List<Song>();
        private List<Review> rate = new List<Review>();
        public string? Name { get; set; }
        public int Duration => songs.Sum(song => song.Duration); //seconds

        public double Average
        {
            get
            {
                if (rate.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return rate.Average(a => a.Rate);
                }
            }
        }

        public Album(string? name)
        {
            Name = name;
            //Year = year;
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void ShowAlbum()
        {
            Console.WriteLine(Name);
            Console.WriteLine(songs.Count + " songs, " + Duration + " seconds");
            Console.WriteLine("");

            for (var i = 0; i < songs.Count; i++)
            {
                Console.WriteLine("Song #" + (i + 1) + ": " + songs[i].Name);
            }

        }

        public void Rate(Review review)
        {
            rate.Add(review);
        }
    }
}