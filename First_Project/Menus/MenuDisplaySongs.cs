using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuDisplaySongs : Menu
    {
        public override void Execute(Dictionary<string, Artist> artists)
        {
            base.Execute(artists);
            Console.WriteLine("Enter in the artist: ");
            string artistName = Console.ReadLine()!;

            if (artists.ContainsKey(artistName))
            {
                Artist artist = artists[artistName];
                Console.WriteLine("\nDiscography:");
                artist.DisplayDiscography();
                Console.WriteLine("\nEnter any key to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nThe artist {artistName} was not found!");
                Console.WriteLine("Enter any key to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}