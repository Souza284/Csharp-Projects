using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Project04.Models
{
    internal class JsonAPI
    {
        private static string? File { get; set; }
        public static Pokemon? DeserializedFile { get; set; }
        public static async Task ExtractJsonFile()
        {
            using (HttpClient client = new())
            {
                File = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/");

                DeserializedFile = JsonConvert.DeserializeObject<Pokemon>(File);

                //Console.WriteLine(File);
            }

        }
    }
}