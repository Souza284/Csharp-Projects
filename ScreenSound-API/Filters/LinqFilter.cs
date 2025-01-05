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
    }
}