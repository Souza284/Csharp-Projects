using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Project04.Models;

internal class Pokemon
{
    [JsonPropertyName("results")]
    public Pokemon[]? Results { get; set; }
    public int Count { get; set; }
    public string? Name { get; set; }
    public string? Next { get; set; }

    public static void DisplayPokemonList(Pokemon file)
    {
        /*for (var i = 0; i < file.Results!.Count(); i++)
        {
            Console.WriteLine(file.Name);
        }*/

        foreach (var pokemonName in file.Results!)
        {
            Console.WriteLine(pokemonName.Name);
        }

        Console.WriteLine("Would you like to display more 20 pokemons? [yes/no]");
        var answer = Console.ReadLine()!;

        if (answer == "yes")
        {
            
        }
    }
}