using Project02.Models;

namespace Project02.Menus
{
    internal class MenuRegisterPet: MenuMain
    {
        public override void Execute()
        {
            base.Execute();

            Pet pet = new();

            Console.WriteLine("Register Pet\n");

            Console.WriteLine("Dog[1] \nCat[2]");
            var option = Convert.ToInt32(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                {
                    pet.RegisterPet("Dog");
                    break;
                }
            }
        }
    }
}