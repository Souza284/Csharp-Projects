using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuRegisterArtist : Menu
    {
        public override void Execute(Dictionary<string, Artist> artists)
        {
            base.Execute(artists);

            Console.Write("Enter in the artist: ");
            string artistName = Console.ReadLine()!;

            Console.Write("Enter in the bio: ");
            string artistBio = Console.ReadLine()!;

            Artist artist = new Artist(artistName, artistBio);
            artists.Add(artistName, artist);
            Console.WriteLine($"The artist {artistName} was successfully registered!");
            Console.WriteLine("Enter any key to go back to the menu");
            Console.ReadKey();
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}