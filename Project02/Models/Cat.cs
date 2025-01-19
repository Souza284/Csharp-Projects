using Project02.Filters;

namespace Project02.Models
{
    internal class Cat : Pet
    {
        public IEnumerable<Pet>? CatList { get; set; }
        public Cat() { }
        public Cat(string name, string race, int age)
        {
            Name = name;
            Race = race;
            Age = age;
        }

        public override void RegisterPet()
        {
            base.RegisterPet();
            Console.WriteLine("Cat Register\n");

            Console.WriteLine("Race: ");
            var race = Console.ReadLine()!;

            Console.WriteLine("Name: ");
            var name = Console.ReadLine()!;

            Console.WriteLine("Age: ");
            var age = int.Parse(Console.ReadLine()!);

            Cat cat = new(name, race, age);
            cat.Type = "Cat";

            Thread.Sleep(1000);

            Pet.AddPetToList(cat);

            Console.WriteLine("Cat successfuly registered!");

            Pet.GeneratePetJsonFile();

            Console.ReadKey();

            Console.Clear();
        }

        public override void DisplayPetList(int option, List<Pet> pets)
        {
            base.DisplayPetList(option, PetList);

            CatList = PetList.Where(p => p.Type!.Equals("Cat")).Select(p => p).ToList();

            foreach (var cat in CatList)
            {
                Console.WriteLine(cat.Name);
            }

        }

        public void Action()
        {
            Console.WriteLine($"{Name} does *miauu*");
        }
    }
}