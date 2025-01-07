using System.Text.Json;

namespace ScreenSound_API.Models
{
    internal class FavoriteSongs
    {
        public string? Name { get; set; }
        public List<Song> FavoriteSongsList { get; set; }

        public FavoriteSongs(string? name)
        {
            Name = name;
            FavoriteSongsList = new List<Song>();
        }

        public void AddFavoriteSongs(Song song)
        {
            FavoriteSongsList.Add(song);
        }

        public void DisplayFavoriteSongs()
        {
            Console.WriteLine(Name + " favorite songs");
            foreach(var favoriteSong in FavoriteSongsList)
            {
                Console.WriteLine(favoriteSong.Artist + " - " + favoriteSong.Name);
            }
        }
        public void GenerateJsonFile()
        {
            string json = JsonSerializer.Serialize(new {name = Name, songs = FavoriteSongsList});
            string fileName = "Favorite-songs-" + Name + ".json";

            File.WriteAllText(fileName, json); 
            Console.WriteLine("Json file created: " + Path.GetFullPath(fileName));
        }
    }
}