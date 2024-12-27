// Screen Sound!
using First_Project.Menus;
using First_Project.Models;

Dictionary<string, Band> Bands = new();
Dictionary<int, Menu> menus = new();

menus.Add(1, new MenuRegisterBand());
menus.Add(2, new MenuReviewBand());
menus.Add(3, new MenuShowList());
menus.Add(4, new MenuRegisterAlbum());
menus.Add(5, new MenuReviewAlbum());
menus.Add(6, new MenuDisplayData());
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
    Console.WriteLine("Type 1 to register a band ");
    Console.WriteLine("Type 2 to show all the bands ");
    Console.WriteLine("Type 3 to evaluate a band ");
    Console.WriteLine("Type 4 to show the band rating ");
    Console.WriteLine("Type 5 to register an album of a band ");
    Console.WriteLine("Type 0 to exit \n");

    Console.Write("Option: ");
    int Option = Convert.ToInt32(Console.ReadLine());

    if (menus.ContainsKey(Option))
    {
        Menu menuDisplayed = menus[Option];
        menuDisplayed.Execute(Bands);

        if (Option != 0) Show_menu();

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Not valid option...");
        Console.ForegroundColor = ConsoleColor.White;
    }

}