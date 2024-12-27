using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuReviewBand: Menu
    {
        public override void Execute(Dictionary<string, Band> Bands)
        {
            base.Execute(Bands);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
▒█▀▀█ █▀▀█ ▀▀█▀▀ ░▀░ █▀▀▄ █▀▀▀ 　 █▀▀█ 　 █▀▀▄ █▀▀█ █▀▀▄ █▀▀▄ 
▒█▄▄▀ █▄▄█ ░░█░░ ▀█▀ █░░█ █░▀█ 　 █▄▄█ 　 █▀▀▄ █▄▄█ █░░█ █░░█ 
▒█░▒█ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀▀▀▀ 　 ▀░░▀ 　 ▀▀▀░ ▀░░▀ ▀░░▀ ▀▀▀░");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            for (var i = 0; i < Bands.Keys.Count; i++)
            {
                Console.WriteLine("Band #" + (i + 1) + ": " + Bands.Keys.ElementAt(i));
            }
            Console.WriteLine("What band do you want to rate? ");
            var bandReviewing = Console.ReadLine()!;//bandReviewing = band name you wanna rate

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
                Console.Write("Please enter your review about the band " + bandReviewing + ": ");
                var review = Review.Convert(Console.ReadLine()!);
                band.AddRate(review);

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