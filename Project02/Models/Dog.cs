namespace Project02.Models
{
    internal class Dog: Pet, IPet
    {
        public string? Name { get;}
        public string? Race { get;}
        public int Age { get;}
        //private Dictionary<Dog, string> Dogs = new();

        public Dog(string name, string race, int age)
        {
            Name = name;
            Race = race;
            Age = age;
        }

        public override void RegisterPet(string type)
        {
            base.RegisterPet(type);
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

            Pet.GeneratePetJsonFile();

        }

        public void Action()
        {
            Console.WriteLine($"{Name} does *woof*");
        }
    }
}