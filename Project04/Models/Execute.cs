using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project04.Models
{
    internal class Execute
    {
        public static void DisplayMenu(Pokemon file)
        {
            Console.WriteLine("Welcome to Pokemon App!");

            Console.WriteLine("[1] Display pokemon list\n[2] Pick up a pokemon\n[3] Display the data of the chosen pokemon\n[-1] Exit");

            Console.WriteLine("What would you like to do?");
            var option = int.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                {
                    Console.Clear();
                    //Pokemon.DisplayPokemonList();
                    break;
                }
            }
        }
    }
}