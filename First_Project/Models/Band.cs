namespace First_Project.Models
{
    internal class Band
    {
        private List<Album> albumList = new List<Album>();
        private List<double> rate = new List<double>();
        public double Average => rate.Average();
        public string? Name { get; set; }

        public Band(string? name)
        {
            Name = name;
        }
        public void AddRate(double review)
        {
            rate.Add(review);
        }

        public void AddAlbum(Album album)
        {
            albumList.Add(album);
        }

        public void ViewDiscography()
        {
            for (var i = 0; i < albumList.Count; i++)
            {
                Console.WriteLine("Album #" + (i + 1) + ": " + albumList[i].Name);
            }
        }
    }
}