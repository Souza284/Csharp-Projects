namespace First_Project.Models
{
    public class Episode
    {
        public string? Title { get; set; }
        public int Number { get; set; }
        public double Duration { get; set; } //minn
        public List<string> Guests = new List<string>();

        public string Resume => $"{Number}. {Title} ({Duration} min)";

        public Episode(string title, int number, double duration)
        {
            Title = title;
            Number = number;
            Duration = duration;
        }

        public void AddGuest(string guest)
        {
            Guests.Add(guest);
        }

        public void DisplayData()
        {
            Console.WriteLine(Resume);
            Console.Write("Guests: ");

            foreach (var guest in Guests)
            {
                Console.Write(guest);
            }
        }
    }
}