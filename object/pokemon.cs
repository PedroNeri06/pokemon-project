using System.Text.Json.Serialization;
using Pokemon.Interface;

namespace Pokemon.Object;

internal class PokemonReal : Ipokemon
{

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("types")]
    public List<PokeType> types { get; set; }

    [JsonPropertyName("sprites")]
    public Sprites sprites { get; set; }


    [JsonPropertyName("height")]
    public int height { get; set; }

    [JsonPropertyName("weight")]
    public int weight { get; set; }
};