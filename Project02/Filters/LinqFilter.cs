using System.Text.Json;
using Project02.Models;

namespace Project02.Filters
{
    internal class LinqFilter
    {
        private static IEnumerable<Pet>? CatList {get; set;}

        public static void DisplayCatList(List<Pet> pets)
        {
            var catList = pets.Where(p => p.Type!.Equals("Cat")).Select(p => p);

            foreach(var cat in catList)
            {
                Console.WriteLine(cat.Name);
            }
        }
    }
}