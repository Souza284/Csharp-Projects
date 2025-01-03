﻿//Petshop

using Project02.Menus;

var options = new Dictionary<int, MenuMain>();

options.Add(1, new MenuRegisterPet());
options.Add(2, new MenuAdoptPet());

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
        menu.Execute();
    }
    else
    {
        throw new ArithmeticException("No valid option...");
    }
}