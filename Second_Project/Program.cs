using Second_Project;

Album michaeljacksonAlbum = new Album();
michaeljacksonAlbum.Name = "Thriller";

Song song1 = new Song();
song1.Name = "Thriller";
song1.Duration = 357;

Song song2 = new Song();
song2.Name = "Beat It";
song2.Duration = 248;

michaeljacksonAlbum.AddSong(song1);
michaeljacksonAlbum.AddSong(song2);

michaeljacksonAlbum.ShowAlbum();