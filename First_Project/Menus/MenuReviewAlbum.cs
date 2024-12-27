using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuReviewAlbum : Menu
    {
        public override void Execute(Dictionary<string, Band> Bands)
        {
            base.Execute(Bands);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
▒█▀▀█ █▀▀█ ▀▀█▀▀ ░▀░ █▀▀▄ █▀▀▀ 　 █▀▀█ █▀▀▄ 　 ░█▀▀█ █░░ █▀▀▄ █░░█ █▀▄▀█ 
▒█▄▄▀ █▄▄█ ░░█░░ ▀█▀ █░░█ █░▀█ 　 █▄▄█ █░░█ 　 ▒█▄▄█ █░░ █▀▀▄ █░░█ █░▀░█ 
▒█░▒█ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀▀▀▀ 　 ▀░░▀ ▀░░▀ 　 ▒█░▒█ ▀▀▀ ▀▀▀░ ░▀▀▀ ▀░░░▀");

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;

            for (var i = 0; i < Bands.Count; i++)
            {
                Console.WriteLine("Band #" + (i + 1) + ": " + Bands.Keys.ElementAt(i));
            }

            Console.WriteLine("What band do you want to rate the album? ");
            var bandReviewing = Console.ReadLine()!;//bandReviewing = band name you wanna rate the album

            if (!Bands.ContainsKey(bandReviewing))
            {
                //throw new Exception($"There is no {reviewing} in the list of bands...");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"There is no {bandReviewing} in the list of bands...");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Please type in any key to go back to the menu.");

                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Band band = Bands[bandReviewing];
                Console.Write("Please enter in the album that you want to rate: ");
                var reviewAlbum = Console.ReadLine()!;

                if (band.albumList.Any(a => a.Name!.Equals(reviewAlbum)))
                {
                    Album album = band.albumList.First(a => a.Name!.Equals(reviewAlbum));
                    Console.WriteLine("Please enter in your review: ");
                    Review review = Review.Convert(Console.ReadLine()!);
                    album.Rate(review);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"There is no {reviewAlbum} in the list of albuns...");

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Please type in any key to go back to the menu.");

                    Console.ReadKey();
                    Console.Clear();
                }

                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your review was successfuly registered!");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please type in anything to go back to the menu.");

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}