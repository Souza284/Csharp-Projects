namespace Second_Project
{
    public class Podcast
    {
        public string? Host { get; set; }
        public string? Name { get; set; }
        public List<Episode> EpisodesList = new List<Episode>();

        public Podcast(string? host, string? name)
        {
            Host = host;
            Name = name;
        }

        public void AddEpisode(Episode episode)
        {
            EpisodesList.Add(episode);
        }

        public void DisplayData()
        {
            Console.WriteLine("Podcast: " + Name);
            Console.WriteLine("Host: " + Host);
            //Console.WriteLine("Episodes: " + EpisodesList.Count);
        }
    }
}