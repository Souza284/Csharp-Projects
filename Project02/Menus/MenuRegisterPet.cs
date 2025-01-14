using Project02.Models;

namespace Project02.Menus
{
    internal class MenuRegisterPet : MenuMain
    {
        public override void Execute(Dictionary<int, Pet> Pets)
        {
            base.Execute(Pets);

            Console.WriteLine("Register Pet\n");

            Console.WriteLine("Dog[1] \nCat[2]");
            var option = Convert.ToInt32(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    {
                        Pets[1].RegisterPet();
                        break;
                    }
                case 2:
                    {
                        Pets[2].RegisterPet();
                        break;
                    }
            }
        }
    }
}