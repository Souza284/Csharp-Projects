
using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuRegisterBand: Menu
    {
        public override void Execute(Dictionary<string, Band> Bands)
        {
            base.Execute(Bands);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ 　 ▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ ▀▀█▀▀ ░▀░ █▀▀█ █▀▀▄ 
▒█▀▀▄ █▄▄█ █░░█ █░░█ 　 ▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▄▄▀ █▄▄█ ░░█░░ ▀█▀ █░░█ █░░█ 
▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ 　 ▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀▀▀▀ ▀░░▀");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter in the band: ");
            var nameBand = Console.ReadLine()!;
            Bands.Add(nameBand, new Band(nameBand));

            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.WriteLine("The band " + nameBand + " was successfuly registered!");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please type in any key to go back to the menu.");

            Console.ReadKey();
            Console.Clear();

        }
    }
}