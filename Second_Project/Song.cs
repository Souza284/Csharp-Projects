namespace Second_Project
{
    public class Song
    {
        public string? Name { get; set; }
        public string? Artist { get; set; }
        public int Duration { get; set; } //seconds
        public bool Avaiable { get; set; }

        /*public Song(string name, string artist, double duration, bool avaiable)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
            Avaiable = avaiable;
        }*/


        public void DisplayData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Artist: " + Artist);
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