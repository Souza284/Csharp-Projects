using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuDisplayArtist: Menu
    {
        public override void Execute(Dictionary<string, Artist> songs)
        {
            base.Execute(songs);

            foreach(var artist in songs.Keys)
            {
                Console.WriteLine(artist);
            }

            Console.WriteLine("Enter any key to go back to the menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}