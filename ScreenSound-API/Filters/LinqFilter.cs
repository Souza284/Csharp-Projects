using ScreenSound_API.Models;

namespace ScreenSound_API.Filters
{
    internal class LinqFilter
    {
        public static void GenreFilter(List<Song> songs)
        {
            var allGenres = songs.Select(genre => genre.Genre).Distinct().ToList(); 
            foreach (var genre in allGenres)
            {
                Console.WriteLine(" - " + genre);
            }
        }
        public static void FilterArtistsByGender(List<Song> songs, string genre)
        {
            var artistsByGenre = songs.OrderBy(songs => songs.Artist).Where(songs => songs.Genre!.Contains(genre)).Select(songs => songs.Artist).Distinct().ToList();

            Console.WriteLine("Artists by genre >>> " + genre);
            foreach(var artist in artistsByGenre)
            {
                Console.WriteLine(" - " + artist);
            }
        }

        public static void FilterSongsByArtist(List<Song> songs, string artist)
        {
            var songsByArtist = songs.OrderBy(songs => songs.Artist).Where(songs => songs.Artist!.Equals(artist)).Select(songs => songs.Name).ToList();

            Console.WriteLine(artist + " songs");
            foreach(var song in songsByArtist)
            {
                Console.WriteLine(" - " + song);
            }
        }
    }
}