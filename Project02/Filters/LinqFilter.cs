using System.Text.Json;
using Project02.Models;

namespace Project02.Filters
{
    internal class LinqFilter : Pet
    {
        public override void DisplayPetList(List<Pet> pets, int option)
        {
            base.DisplayPetList(pets, option);
            
            var catList = pets.Where(p => p.Type!.Equals("Cat")).Select(p => p);
            var dogList = pets.Where(p => p.Type!.Equals("Dog")).Select(p => p);

            switch (option)
            {
                case 1:
                    {
                        foreach (var dog in dogList)
                        {
                            Console.WriteLine(dog.Name);
                        }
                        break;
                    }
                case 2:
                    {
                        foreach (var cat in catList)
                        {
                            Console.WriteLine(cat.Name);
                        }
                        break;
                    }
                case 3:
                {
                    foreach (var pet in pets)
                    {
                        Console.WriteLine(pet.Name);
                    }
                    break;
                }
            }
        }
    }
}