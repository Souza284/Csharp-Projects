namespace Project02.Models
{
    internal class Cat : Pet
    {
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

        public void Action()
        {
            Console.WriteLine($"{Name} does *miauu*");
        }
    }
}