// Screen Sound!
public class Program
{
    static void Main(string[] args)
    {
        var Bands = new Dictionary<string, List<double>>();

        Console.WriteLine("");
        Show_menu();

        static void Show_msg() //show initial message
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
        }

        void Show_menu()//show menu
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Show_msg();

            var Welcome_msg = "\nWelcome to Screen Sound!";

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(Welcome_msg);
            Console.WriteLine("\nType 1 to register a band: ");
            Console.WriteLine("Type 2 to show all the bands: ");
            Console.WriteLine("Type 3 to evaluate a band: ");
            Console.WriteLine("Type 4 to show a note from a band: ");
            Console.WriteLine("Type 0 to exit: \n");

            Console.Write("Option: ");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    RegisterBand();
                    break;
                case 2:
                    Show_List();
                    break;
                case 3:
                    Review_Band();
                    break;
                case 4:
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Not valid option...");
                    break;
            }
        }

        void RegisterBand()//option 1
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ 　 ▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ ▀▀█▀▀ ░▀░ █▀▀█ █▀▀▄ 
▒█▀▀▄ █▄▄█ █░░█ █░░█ 　 ▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▄▄▀ █▄▄█ ░░█░░ ▀█▀ █░░█ █░░█ 
▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ 　 ▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀▀▀▀ ▀░░▀");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter in the band: ");
            var nameBand = Console.ReadLine()!;
            Bands.Add(nameBand, new List<double>());

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("The band " + nameBand + " was successfuly registered!");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Type in anything to go back to the menu");

            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();

            Show_menu();
        }

        void Show_List() //option 2
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(@"
▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀ █▀▀█ █▀▀ █▀▀▄ 　 █▀▀▄ █▀▀█ █▀▀▄ █▀▀▄ █▀▀ 
▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▀▀ █▄▄▀ █▀▀ █░░█ 　 █▀▀▄ █▄▄█ █░░█ █░░█ ▀▀█ 
▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀░ 　 ▀▀▀░ ▀░░▀ ▀░░▀ ▀▀▀░ ▀▀▀");

            Console.ForegroundColor = ConsoleColor.White;

            /*foreach (string band in Bands.Keys)
            {
                Console.WriteLine(band);
            }*/

            for (var i = 0; i < Bands.Keys.Count; i++)
            {
                Console.WriteLine("Band #" + (i + 1) + ": " + Bands.Keys.ElementAt(i));
            }

            Console.WriteLine("Type in anything to go back to the menu");

            Console.ReadKey();

            Thread.Sleep(1000);

            Console.Clear();

            Show_menu();
        }

        void Review_Band()//option 3
        {
            Console.Clear();

            for (var i = 0; i < Bands.Keys.Count; i++)
            {
                Console.WriteLine("Band #" + (i + 1) + ": " + Bands.Keys.ElementAt(i));
            }
            Console.WriteLine("What band do you want to review? ");
            var reviewing = Console.ReadLine()!;

            if (!Bands.ContainsKey(reviewing))
            {
                throw new Exception($"There is no {reviewing} in the list band...");
            }
        }
    }
}