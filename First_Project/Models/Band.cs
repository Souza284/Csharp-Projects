namespace First_Project.Models
{
    internal class Band: IReview
    {
        public List<Album> albumList = new List<Album>();
        private List<Review> rate = new List<Review>();
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
        public string? Name { get; set; }

        public Band(string? name)
        {
            Name = name;
        }
        public void AddRate(Review review)
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

        public void Rate(Review review)
        {
            rate.Add(review);
        }
    }
}