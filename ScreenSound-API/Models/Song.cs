using System.Text.Json.Serialization;

namespace ScreenSound_API.Models
{
    internal class Song
    {
        private string[] tonality  = { "C", "C#", "D", "Eb", "E", "F" };
        [JsonPropertyName("song")]
        public string? Name { get; set; }
        [JsonPropertyName("artist")]
        public string? Artist { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duration { get; set; }
        [JsonPropertyName("genre")]
        public string? Genre { get; set; }
        [JsonPropertyName("key")]
        public int Key { get; set; }
        public string? Tonality
        {
            get 
            {
                return tonality[Key];
            }
        }

        public void DisplayDataSong()
        {
            Console.WriteLine("Song: " + Name);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Duration: " + Duration);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Tonality: " + Tonality);
        }
    }
}