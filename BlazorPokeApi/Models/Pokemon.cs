using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites? Sprites { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("front_default")]
        public string? FrontDefault { get; set; }
    }
}
