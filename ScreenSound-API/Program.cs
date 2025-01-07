using System.Text.Json;
using ScreenSound_API.Models;
using ScreenSound_API.Filters;

using (HttpClient client = new HttpClient())
{
    try
    {
        string answer = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(answer);

        var songs = JsonSerializer.Deserialize<List<Song>>(answer)!;
        //LinqFilter.GenreFilter(songs);
        //LinqOrder.DisplayArtists(songs);
        /*Console.WriteLine("Genre: ");
        var genre = Console.ReadLine()!;
        LinqFilter.FilterArtistsByGender(songs, genre);*/
        //Console.WriteLine("Artist: ");
        //var artist = Console.ReadLine()!;
        //LinqFilter.FilterSongsByArtist(songs, artist);

        var favoriteSongs = new FavoriteSongs("Pedro");
        favoriteSongs.AddFavoriteSongs(songs[1]);
        favoriteSongs.AddFavoriteSongs(songs[2]);
        favoriteSongs.AddFavoriteSongs(songs[3]);

        favoriteSongs.DisplayFavoriteSongs();
        favoriteSongs.GenerateJsonFile();
    }
    catch (Exception e)
    {
        Console.WriteLine("There is a problem: " + e.Message);    
    }
}
