namespace Second_Project
{
    public class Song
    {
        public string? Name { get; set; }
        public Band? Artist { get; }
        public int Duration { get; set; } //seconds
        public bool Avaiable { get; set; }
        public Genre? Genre { get; set; }

        public Song(string name, Band artist, int duration, Genre genre, bool avaiable)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
            Genre = genre;
            Avaiable = avaiable;
        }


        public void DisplayData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Genre: " + Genre!.MusicGenre);
            Console.WriteLine("Artist: " + Artist!.Name);
            Console.WriteLine("Duration: " + Duration);

            if (Avaiable)
            {
                Console.WriteLine("Avaiable in plan.");
            }
            else
            {
                Console.WriteLine("Purchase the plane Plus+");
            }
        }
    }
}