// Screen Sound!

var Welcome_msg = "Welcome to Screen Sound!";

void Show_msg()
{
        Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

Show_msg();
Console.WriteLine("");

void Show_menu()
{
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
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 0:
            break;
        default: Console.WriteLine("Not valid option...");
            break;
    }
}
Show_menu();
