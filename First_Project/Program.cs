// Screen Sound!
using First_Project.Models;

Dictionary<string, Band> Bands = new();

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

    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("\nWelcome to Screen Sound!");
    Console.WriteLine("Type 1 to register a band ");
    Console.WriteLine("Type 2 to show all the bands ");
    Console.WriteLine("Type 3 to evaluate a band ");
    Console.WriteLine("Type 4 to show the band rating ");
    Console.WriteLine("Type 5 to register an album of a band ");
    Console.WriteLine("Type 0 to exit \n");

    Console.Write("Option: ");
    int Option = Convert.ToInt32(Console.ReadLine());

    switch (Option)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            ShowList();
            break;
        case 3:
            ReviewBand();
            break;
        case 4:
            AverageBand();
            break;
        case 5:
            RegisterAlbum();
            break;
        case 0:
            EndOfProgram();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not valid option...");
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }
}

void RegisterBand()//option 1: Register a band
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
    Bands.Add(nameBand, new Band(nameBand));

    Console.ForegroundColor = ConsoleColor.Green;
    Thread.Sleep(1000);
    Console.WriteLine("The band " + nameBand + " was successfuly registered!");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please type in any key to go back to the menu.");

    Console.ReadKey();
    Console.Clear();

    Show_menu();
}

void ShowList() //option 2: display the list of bands
{
    Console.Clear();

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

    Show_menu();
}

void ReviewBand()//option 3: Rate a band
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

        Show_menu();
    }
    else
    {
        Band band = Bands[bandReviewing];
        Console.Write("Please enter your review about the band " + bandReviewing + ": ");
        var review = Convert.ToInt32(Console.ReadLine());
        band.AddRate(new Review(review));

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

void AverageBand() //option 4: display the average rating of a band
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

        Show_menu();
    }
    else
    {
        Band ratingList = Bands[bandAverage];
        Console.WriteLine($"The band {bandAverage} average rating is {ratingList.Average}");

        Console.WriteLine("Please type in anything to go back to the menu.");

        Console.ReadKey();
        Console.Clear();

        Show_menu();
    }

}

void RegisterAlbum()//option 5: register an album to a band
{
    Console.Clear();

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

        Show_menu();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"There is no {_nameBand} in the list of bands...");

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Please type in anything to go back to the menu.");

        Console.ReadKey();
        Console.Clear();

        Show_menu();
    }
}

void EndOfProgram()
{
    Console.Clear();

    Console.WriteLine("Thank you for using it!");
}