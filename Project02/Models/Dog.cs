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

            Pet.GeneratePetJsonFile();

            Console.ReadKey();

            Console.Clear();
        }

        public void Action()
        {
            Console.WriteLine($"{Name} does *woof*");
        }
    }
}