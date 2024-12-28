using (HttpClient client = new HttpClient())
{
    try
    {
        string answer = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(answer);
    }
    catch (Exception e)
    {
        Console.WriteLine("There is a problem: " + e.Message);    
    }
}