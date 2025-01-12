//Petshop

using Project02.Menus;
using Project02.Models;

var options = new Dictionary<int, MenuMain>
{
    { 1, new MenuRegisterPet() },
    { 2, new MenuAdoptPet() }
};

var Pets = new Dictionary<int, Pet>
{
    {1, new Dog()},
    {2, new Cat()}
};


PetShop();
void PetShop()
{
    Console.WriteLine("petshop pop");

    Console.WriteLine("\nWelcome to the Petshop pop!");

    Console.WriteLine("Please type in 1 to register a pet \nPlease type in 2 to adopt a pet \nPlease enter -1 to exit ");
    var option = Int32.Parse(Console.ReadLine()!);

    if (options.ContainsKey(option))
    {
        MenuMain menu = options[option];
        menu.Execute(Pets);
        PetShop();
    }
    else
    {
        throw new ArithmeticException("No valid option...");
    }
}