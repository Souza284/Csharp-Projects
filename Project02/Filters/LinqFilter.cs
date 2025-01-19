using System.Text.Json;
using Project02.Models;

namespace Project02.Filters
{
    internal class LinqFilter : Pet
    {

        public static IEnumerable<Pet>? CatList {get; set;}
        public static IEnumerable<Pet>? DogList { get; set; }
        public static void DisplayPetList(List<Pet> pets, int option)
        {
            CatList = pets.Where(p => p.Type!.Equals("Cat")).Select(p => p).ToList();
            DogList = pets.Where(p => p.Type!.Equals("Dog")).Select(p => p).ToList();

            switch (option)
            {
                case 1:
                    {
                        foreach (var dog in DogList)
                        {
                            Console.WriteLine(dog.Name);
                        }
                        break;
                    }
                case 2:
                    {
                        foreach (var cat in CatList)
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