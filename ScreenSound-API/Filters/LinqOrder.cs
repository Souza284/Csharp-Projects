using ScreenSound_API.Models;

namespace ScreenSound_API.Filters
{
    internal class LinqOrder
    {
        public static void DisplayArtists(List<Song> songs)
        {
            var orderedArtists = songs.OrderBy(songs => songs.Artist).Select(song => song.Artist).Distinct().ToList();

            Console.WriteLine("Artists List");
            foreach (var artist in orderedArtists)
            {
                Console.WriteLine(" - " + artist);
            }
        }
    }
}