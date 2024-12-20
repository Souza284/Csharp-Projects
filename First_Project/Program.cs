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
            Console.ForegroundColor = ConsoleColor.Red;

            Show_msg();

            var Welcome_msg = "\nWelcome to Screen Sound!";

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(Welcome_msg);
            Console.WriteLine("\nType 1 to register a band ");
            Console.WriteLine("Type 2 to show all the bands ");
            Console.WriteLine("Type 3 to evaluate a band ");
            Console.WriteLine("Type 4 to show the band rating ");
            Console.WriteLine("Type 0 to exit \n");

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
                    Average_Band();
                    break;
                case 0:
                    End_Of_Program();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not valid option...");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        void RegisterBand()//option 1
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ 　 ▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ ▀▀█▀▀ ░▀░ █▀▀█ █▀▀▄ 
▒█▀▀▄ █▄▄█ █░░█ █░░█ 　 ▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▄▄▀ █▄▄█ ░░█░░ ▀█▀ █░░█ █░░█ 
▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ 　 ▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀▀▀▀ ▀░░▀");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter in the band: ");
            var nameBand = Console.ReadLine()!;
            Bands.Add(nameBand, new List<double>());

            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.WriteLine("The band " + nameBand + " was successfuly registered!");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please type in any key to go back to the menu.");

            Console.ReadKey();
            Console.Clear();

            Show_menu();
        }

        void Show_List() //option 2
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀ █▀▀█ █▀▀ █▀▀▄ 　 █▀▀▄ █▀▀█ █▀▀▄ █▀▀▄ █▀▀ 
▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▀▀ █▄▄▀ █▀▀ █░░█ 　 █▀▀▄ █▄▄█ █░░█ █░░█ ▀▀█ 
▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀░ 　 ▀▀▀░ ▀░░▀ ▀░░▀ ▀▀▀░ ▀▀▀");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            /*foreach (string band in Bands.Keys)
            {
                Console.WriteLine(band);
            }*/

            for (var i = 0; i < Bands.Keys.Count; i++)
            {
                Console.WriteLine("Band #" + (i + 1) + ": " + Bands.Keys.ElementAt(i));
            }

            Console.WriteLine("Please type in any key to go back to the menu.");

            Console.ReadKey();
            Console.Clear();

            Show_menu();
        }

        void Review_Band()//option 3
        {
            Console.Clear();

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
            Console.WriteLine("What band do you want to review? ");
            var reviewing = Console.ReadLine()!;

            if (!Bands.ContainsKey(reviewing))
            {
                //throw new Exception($"There is no {reviewing} in the list of bands...");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"There is no {reviewing} in the list of bands...");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Please type in any key to go back to the menu.");

                Console.ReadKey();
                Console.Clear();

                Show_menu();
            }
            else
            {
                Console.Write("Please enter your review about the band " + reviewing + ": ");
                var review = Convert.ToDouble(Console.ReadLine());
                Bands[reviewing].Add(review);

                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your review was successfuly registered!");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please type in anything to go back to the menu.");

                Console.ReadKey();
                Console.Clear();

                Show_menu();
            }
        }

        void Average_Band() //option 4
        {
            Console.Clear();

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

            Console.WriteLine("What band do you want to see the average rating? ");
            var reviewAverage = Console.ReadLine()!;

            if (!Bands.ContainsKey(reviewAverage))
            {
                //throw new Exception($"There is no {reviewing} in the list of bands...");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"There is no {reviewAverage} in the list of bands...");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Please type in anything to go back to the menu.");

                Console.ReadKey();
                Console.Clear();

                Show_menu();
            }
            else
            {
                var ratingList = Bands[reviewAverage];
                Console.WriteLine($"The band {reviewAverage} average rating is {ratingList.Average()}");

                Console.WriteLine("Please type in anything to go back to the menu.");

                Console.ReadKey();
                Console.Clear();

                Show_menu();
            }

        }

        void End_Of_Program()
        {
            Console.Clear();

            Console.WriteLine("Thank you for using it!");
        }
    }
}