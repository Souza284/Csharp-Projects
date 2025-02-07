using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    public static void Main(string[] args)
    {
        /*using(HttpClient client = new())
        {
            var file = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/?utm_medium=email&_hsenc=p2ANqtz-_UmswzP1bsPYX0SQK16eIZwVSJjNUxk69AwwS5F1gxXOInf6UCHIoA7mIk4gIJk3kpbW60eTHxKc4mKie1zeeH8Dv7wg&_hsmi=231292845&utm_content=231292845&utm_source=hs_automation");

            //var json = JsonSerializer.Deserialize<List<string>>(file);

            Console.Write(file);
        }*/

        var file = File.ReadAllText(@"C:\Users\Pedro\Documents\JsonTests\test.json");

        var deserializedFile = JsonConvert.DeserializeObject<Pokemon>(file);

        /*foreach(var pokemon in deserializedFile.Result)
        {
            Console.WriteLine(pokemon => pokemon.Name);
        }*/

        //Console.Write(deserializedFile.Result);
    }
}

public class Pokemon
{
    [JsonPropertyName("results")]
    //public string Result { get; set; }
    //public Pokemon[] Result { get; set; }
    public Pokemon[] Result = new Pokemon[20];
    //public Dictionary<Pokemon,string> Result = new();

    [JsonPropertyName("count")]
    public string? Count { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}