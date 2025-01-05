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
        LinqFilter.GenreFilter(songs);
    }
    catch (Exception e)
    {
        Console.WriteLine("There is a problem: " + e.Message);    
    }
}
