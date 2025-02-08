using System.Text.Json;
using Newtonsoft.Json;
using Project02.Filters;
using Project02.Models;

namespace Project02.Models
{
    internal class Pet
    {
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Race { get; set; }
        public int Age { get; set; }
        public static List<Pet> PetList = new();
        public virtual void RegisterPet()
        {
            Console.Clear();
        }

        public static void AddPetToList(Pet pet)
        {
            PetList.Add(pet);
        }

        /*public static void CreatePetJsonFile()
        {
            var fileAddress = @"C:\Users\Pedro\Documents\MyProjects\Csharp-Projects\Project02\bin\Debug\net8.0\jsonFile\jsonText.json";

            var json = JsonConvert.SerializeObject(PetList, Formatting.Indented);

            using(FileStream fileStream = new(fileAddress, FileMode.Create))
            using(StreamWriter writer = new(fileStream))
            {
                writer.WriteLine(json);
            }
        }*/

        public static void CreatePetJsonFile()
        {
            var fileAddress = @"C:\Users\Pedro\Documents\MyProjects\Csharp-Projects\Project02\bin\Debug\net8.0\jsonFile\jsonPetText.json";

            var json = JsonConvert.SerializeObject(PetList);

            if (File.Exists(fileAddress) == false)
            {
                File.WriteAllText(fileAddress, json);
            }
        }
        public virtual void DisplayPetList(int option, List<Pet> pets)
        {
            Console.Clear();
            Console.WriteLine("List");
        }

    }
}