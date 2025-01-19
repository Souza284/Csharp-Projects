
namespace Project02.Models
{
    internal class Dog : Pet, IPet
    {
        public Dog() { }

        public Dog(string name, string race, int age)
        {
            Name = name;
            Race = race;
            Age = age;
        }

        public override void RegisterPet()
        {
            base.RegisterPet();
            Console.WriteLine("Dog Register\n");

            Console.WriteLine("Race: ");
            var race = Console.ReadLine()!;

            Console.WriteLine("Name: ");
            var name = Console.ReadLine()!;

            Console.WriteLine("Age: ");
            var age = int.Parse(Console.ReadLine()!);

            Dog dog = new(name, race, age);
            dog.Type = "Dog";

            Thread.Sleep(1000);

            Pet.AddPetToList(dog);

            Console.WriteLine("Dog successfuly registered!");

            Console.ReadKey();

            Console.Clear();
        }

        public override void DisplayPetList(int option, List<Pet> pets)
        {
            base.DisplayPetList(option, pets);

            Pet.GeneratePetJsonFile();
            var dogList = pets.Where(p => p.Type!.Equals("Dog")).Select(p => p.Name).ToList();

            foreach (var dog in dogList)
            {
                Console.WriteLine(dog);
            }

            Console.ReadKey();

            Console.Clear();
        }

        public void Action()
        {
            Console.WriteLine($"{Name} does *woof*");
        }
    }
}