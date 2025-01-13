using System.Text.Json;
using Project02.Models;

namespace Project02.Models
{
    internal class Pet
    {
        public string? Type {get; set;}
        public string? Name { get; set;}
        public string? Race { get; set;}
        public int Age { get; set;}
        private static List<Pet> PetList = new(); 
        public virtual void RegisterPet()
        {
            Console.Clear();
        }

        public static void AddPetToList(Pet pet)
        {
            PetList.Add(pet);
        }

        public static void GeneratePetJsonFile()
        {
            var json = JsonSerializer.Serialize(new {petlist = PetList});
            var fileName = "Pet List";

            File.WriteAllText(fileName, json);

            //Console.WriteLine(fileName + ": " + Path.GetFullPath(fileName));
        }

        public static void ClearPetJsonFile()
        {
            //File.Delete(fileName, json)
        }
    }

}