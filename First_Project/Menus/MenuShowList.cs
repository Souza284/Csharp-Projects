using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuShowList: Menu
    {
        public override void Execute(Dictionary<string, Band> Bands)
        {
            base.Execute(Bands);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀ █▀▀█ █▀▀ █▀▀▄ 　 █▀▀▄ █▀▀█ █▀▀▄ █▀▀▄ █▀▀ 
▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▀▀ █▄▄▀ █▀▀ █░░█ 　 █▀▀▄ █▄▄█ █░░█ █░░█ ▀▀█ 
▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀░ 　 ▀▀▀░ ▀░░▀ ▀░░▀ ▀▀▀░ ▀▀▀");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            for (var i = 0; i < Bands.Keys.Count; i++)
            {
                Console.WriteLine("Band #" + (i + 1) + ": " + Bands.Keys.ElementAt(i));
            }

            Console.WriteLine("Please type in any key to go back to the menu.");

            Console.ReadKey();
            Console.Clear();
        }
    }
}