// Screen Sound!
using First_Project.Menus;
using First_Project.Models;

//Dictionary<string, Band> Bands = new();
Dictionary<string, Artist> Artists = new();
Dictionary<int, Menu> menus = new();

menus.Add(1, new MenuRegisterArtist());
menus.Add(2, new MenuRegisterSong());
menus.Add(3, new MenuDisplayArtist());
menus.Add(4, new MenuDisplaySongs());
menus.Add(0, new MenuExit());


Console.WriteLine("");
Show_menu();

void Show_menu()//show menu
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("\nWelcome to Screen Sound!");
    Console.WriteLine("Type 1 to register an artist ");
    Console.WriteLine("Type 2 to register a song from an artist ");
    Console.WriteLine("Type 3 to display all the artists ");
    Console.WriteLine("Type 4 to display all the songs from an artist ");
    //Console.WriteLine("Type 5 to evaluate an album ");
    //Console.WriteLine("Type 6 to display the band data ");
    Console.WriteLine("Type 0 to exit \n");

    Console.Write("Option: ");
    int Option = Convert.ToInt32(Console.ReadLine());

    if (menus.ContainsKey(Option))
    {
        Menu menuDisplayed = menus[Option];
        menuDisplayed.Execute(Artists);

        if (Option != 0) Show_menu();

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Not valid option...");
        Console.ForegroundColor = ConsoleColor.White;
    }

}