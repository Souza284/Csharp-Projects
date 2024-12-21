using Second_Project;

// Music

Band band1 = new("Michael Jackson");

Album band1Album = new("Thriller", 1982);

Song song1 = new("Thriller", band1, 357, new Genre { MusicGenre = "Pop" }, true);

band1Album.AddSong(song1);

band1.AddAlbum(band1Album);

//Podcast

Episode episode1 = new("Astronomy with Dr. Smith", 1, 84);
episode1.AddGuest("Dr. Smith");

Podcast podcast1 = new("Igor3K", "Flow Podcast");
podcast1.AddEpisode(episode1);


Console.WriteLine("Type in 1 to go to music.");
Console.WriteLine("Type in 2 to go to podcasts.");
var option = Convert.ToInt32(Console.ReadLine());

if (option == 1)
{
    band1.ViewDiscography();
    band1Album.ShowAlbum();
    song1.DisplayData();
}
else
{
    podcast1.DisplayData();
    episode1.DisplayData();
}
