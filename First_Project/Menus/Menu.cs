using First_Project.Models;

namespace First_Project.Menus
{
    internal class Menu
    {
        public virtual void Execute(Dictionary<string, Artist> songs)
        {
            Console.Clear();
        }   
    }
}