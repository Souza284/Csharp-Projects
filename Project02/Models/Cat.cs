namespace Project02.Models
{
    internal class Cat : Pet
    {
        public string? Name { get; }
        public string? Race { get; }
        public int Age { get; }


        public Cat(string name, string race, int age)
        {
            Name = name;
            Race = race;
            Age = age;
        }

        public void Action()
        {
            Console.WriteLine($"{Name} does *miauu*");
        }
    }
}