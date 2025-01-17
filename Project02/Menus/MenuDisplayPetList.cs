using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Project02.Filters;
using Project02.Models;

namespace Project02.Menus
{
    internal class MenuDisplayPetList : MenuMain
    {

        public override void Execute(Dictionary<int, Pet> Pets)
        {
            base.Execute(Pets);

            Console.WriteLine("[1] Display dog list \n[2] Display cat list \n[3] Display complete list");
            var option = Convert.ToInt32(Console.ReadLine()!);

            Console.Clear();

            switch (option)
            {
                case 2:
                    {
                        LinqFilter.DisplayCatList(Pet.PetList);
                        break;
                    }
            }
        }
    }
}