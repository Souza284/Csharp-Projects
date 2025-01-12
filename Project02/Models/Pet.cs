using System.Text.Json;
using Project02.Models;

namespace Project02.Models
{
    internal class Pet
    {
        public string? Type {get; set;}
        private static List<Pet> PetList = new(); 
        public virtual void RegisterPet(string type)
        {
            Console.Clear();
        }

        public static void AddPetToList(Pet pet)
        {
            PetList.Add(pet);
        }

        public static void GeneratePetJsonFile()
        {
            var json = JsonSerializer.Serialize(PetList);
            var fileName = "Pet List";

            File.WriteAllText(fileName, json);

            //Console.WriteLine(fileName + ": " + Path.GetFullPath(fileName));
        }
    }

}