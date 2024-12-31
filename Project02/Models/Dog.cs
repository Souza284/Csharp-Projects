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

        public void Action()
        {
            Console.WriteLine($"{Name} does *woof*");
        }
    }
}