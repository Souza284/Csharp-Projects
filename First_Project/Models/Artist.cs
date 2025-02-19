using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Project.Models
{
    internal class Artist
    {
        private List<Song> songs = new();
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public string? ProfilePicture { get; set; }
        public int Id { get; set; }

        public Artist(string name, string bio)
        {
            this.Name = name;
            this.Bio = bio;
            this.ProfilePicture = "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void DisplayDiscography()
        {
            Console.WriteLine(Name + " Discography");

            foreach(var song in songs)
            {
                Console.WriteLine("- " + song.Name);
            }
        }

        public override string ToString()
        {
            return $@"Id: {Id}
                    Name: {Name}
                    Profile: {ProfilePicture}
                    Bio: {Bio}";
        }
    }
}