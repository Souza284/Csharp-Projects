//Petshop

using Project02.Menus;

var options = new Dictionary<int, MenuMain>();

options.Add(1, new MenuRegisterPet());
options.Add(2, new MenuAdoptPet());


static void PetShop()
{
    Console.WriteLine("petshop pop");

    Console.WriteLine("\nWelcome to the Petshop pop!");

    Console.WriteLine("Please type in 1 to register a pet \nPlease type in 2 to adopt a pet ");
    var option = Int32.Parse(Console.ReadLine()!);

    if (option == 1 || option == 2)
    {
        
    }
    else
    {
        throw new ArithmeticException("Oh no... No valid option");
    }
}