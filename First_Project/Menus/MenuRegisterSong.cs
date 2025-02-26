using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuRegisterSong : Menu
    {
        public override void Execute(Dictionary<string, Artist> artists)
        {
            base.Execute(artists);

            Console.Write("Enter in the artist: ");
            string artistName = Console.ReadLine()!;

            if (artists.ContainsKey(artistName))
            {
                Console.Write("Enter in the song: ");
                string songName = Console.ReadLine()!;
                Artist artist = artists[artistName];
                artist.AddSong(new Song(songName));
                Console.WriteLine($"The song {songName} from {artistName} was successfully registered!");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nThe artist {artistName} was not found!");
                Console.WriteLine("Enter in any key to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}