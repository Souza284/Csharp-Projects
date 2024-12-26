namespace First_Project.Models
{
    public class Album
    {
        private List<Song> songs = new List<Song>();
        public string? Name { get; set; }
        public int Duration => songs.Sum(song => song.Duration); //seconds
        //public int Year { get; set; }

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
    }
}