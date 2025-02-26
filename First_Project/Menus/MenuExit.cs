
using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuExit: Menu
    {
        public override void Execute(Dictionary<string, Artist> artists)
        {
            base.Execute(artists);;
            Console.WriteLine("Thank you for using it!"); ;
        }
    }
}