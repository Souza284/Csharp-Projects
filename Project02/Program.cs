//Petshop

using System.Text.Json;
using Project02.Menus;
using Project02.Models;

var options = new Dictionary<int, MenuMain>

{
    {-1, new ExitMenu() },
    { 1, new MenuRegisterPet() },
    { 2, new MenuDisplayPetList()},
    { 3, new MenuAdoptPet() }
};

var Pets = new Dictionary<int, Pet>
{
    { 1, new Dog() },
    { 2, new Cat() },
    { 3, new Pet() }
};

PetShop();
void PetShop()
{
    Console.WriteLine("petshop pop");

    Console.WriteLine("\nWelcome to the Petshop pop!");

    Console.WriteLine("Please type in 1 to register a pet \nPlease enter in 2 to display the pet list \nPlease type in 3 to adopt a pet \nPlease enter -1 to exit ");
    var option = Int32.Parse(Console.ReadLine()!);

    if (options.ContainsKey(option))
    {
        MenuMain menu = options[option];
        menu.Execute(Pets);

        if (option != -1)
        {
            PetShop();
        }
    }
    else
    {
        throw new ArithmeticException("No valid option...");
    }
}