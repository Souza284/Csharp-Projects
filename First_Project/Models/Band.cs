namespace First_Project.Models
{
    public class Band
    {
        private List<Album> albumList = new List<Album>();
        public string? Name { get; set; }

        public Band(string? name)
        {
            Name = name;
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