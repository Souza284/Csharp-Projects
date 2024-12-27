using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuRegisterAlbum: Menu
    {
        public override void Execute(Dictionary<string, Band> Bands)
        {
            base.Execute(Bands);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀ █▀▀█ 　 ░█▀▀█ █░░ █▀▀▄ █░░█ █▀▄▀█ 
▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▀▀ █▄▄▀ 　 ▒█▄▄█ █░░ █▀▀▄ █░░█ █░▀░█ 
▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀ ▀░▀▀ 　 ▒█░▒█ ▀▀▀ ▀▀▀░ ░▀▀▀ ▀░░░▀");

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;

            for (var i = 0; i < Bands.Keys.Count; i++)
            {
                Console.WriteLine("Band #" + (i + 1) + ": " + Bands.Keys.ElementAt(i));
            }

            Console.WriteLine("Please enter in the name of the band that you want to add an album to: ");
            var _nameBand = Console.ReadLine()!;

            if (Bands.ContainsKey(_nameBand))
            {
                Console.WriteLine("Please enter in the name of the album: ");
                var _albumName = Console.ReadLine()!;

                Band band = Bands[_nameBand];

                band.AddAlbum(new Album(_albumName));

                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(1000);
                Console.WriteLine("The album " + _albumName + " was successfuly registered!");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please type in any key to go back to the menu.");

                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"There is no {_nameBand} in the list of bands...");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Please type in anything to go back to the menu.");

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}