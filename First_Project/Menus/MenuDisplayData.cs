using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuDisplayData: Menu
    {
        public override void Execute(Dictionary<string, Band> Bands)
        {
            base.Execute(Bands);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
▒
▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ 　 ▒█▀▀█ █▀▀█ ▀▀█▀▀ ░▀░ █▀▀▄ █▀▀▀ 
▒█▀▀▄ █▄▄█ █░░█ █░░█ 　 ▒█▄▄▀ █▄▄█ ░░█░░ ▀█▀ █░░█ █░▀█ 
▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ 　 ▒█░▒█ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀▀▀▀");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            for (var i = 0; i < Bands.Keys.Count; i++)
            {
                Console.WriteLine("Band #" + (i + 1) + ": " + Bands.Keys.ElementAt(i));
            }

            Console.WriteLine("What band do you want to see the discography? ");
            var bandAverage = Console.ReadLine()!;// band name you wanna see the average

            if (!Bands.ContainsKey(bandAverage))
            {
                //throw new Exception($"There is no {reviewing} in the list of bands...");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"There is no {bandAverage} in the list of bands...");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Please type in anything to go back to the menu.");

                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Band ratingList = Bands[bandAverage];
                Console.WriteLine($"The band {bandAverage} average rating is {ratingList.Average}");

                foreach (var album in ratingList.albumList)
                {
                    Console.WriteLine(album.Name + " - " + album.Average);
                }

                Console.WriteLine("Please type in anything to go back to the menu.");

                Console.ReadKey();
                Console.Clear();

            }

        }
    }
}