
using First_Project.Models;

namespace First_Project.Menus
{
    internal class MenuExit: Menu
    {
        public override void Execute(Dictionary<string, Band> Bands)
        {
            base.Execute(Bands);;
            Console.WriteLine("Thank you for using it!"); ;
        }
    }
}