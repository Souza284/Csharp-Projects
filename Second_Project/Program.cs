using Second_Project;

Band band1 = new Band();
band1.Name = "Michael Jackson";

Album band1Album = new Album();
band1Album.Name = "Thriller";
band1Album.Year = 1982;

Song song1 = new("Thriller", band1, 357, new Genre {MusicGenre = "Pop"}, true);

band1Album.AddSong(song1);
//band1Album.AddSong(song2);

band1.AddAlbum(band1Album);
band1.ViewDiscography();
song1.DisplayData();