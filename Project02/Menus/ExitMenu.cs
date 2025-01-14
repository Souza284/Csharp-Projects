using Project02.Models;

namespace Project02.Menus
{
    internal class ExitMenu: MenuMain
    {
        public override void Execute(Dictionary<int, Pet> Pets)
        {
            base.Execute(Pets);

            Console.WriteLine("Thank you for using it.");
        }
    }
}