﻿using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project04.Models;


/*using(HttpClient client = new())
{
    var file = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/?utm_medium=email&_hsenc=p2ANqtz-_UmswzP1bsPYX0SQK16eIZwVSJjNUxk69AwwS5F1gxXOInf6UCHIoA7mIk4gIJk3kpbW60eTHxKc4mKie1zeeH8Dv7wg&_hsmi=231292845&utm_content=231292845&utm_source=hs_automation");

    //var json = JsonSerializer.Deserialize<List<string>>(file);

    Console.Write(file);
}*/

/*JObject _object = JObject.Parse(file);
string count = (string)_object["count"]!;
List<string> results = _object["results"]!.Select(o => (string?)o["url"]).ToList()!;

foreach(var result in results)
{
    Console.WriteLine(result);
}

Console.WriteLine(count);*/

await JsonAPI.ExtractJsonFile();

Execute.DisplayMenu();