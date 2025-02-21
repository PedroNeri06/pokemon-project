using System.Text.Json.Serialization;

namespace Pokemon.Models;

internal class PokemonModel
{

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("types")]
    public List<TypeModel> types { get; set; }

    [JsonPropertyName("sprites")]
    public SpritesModel sprites { get; set; }


    [JsonPropertyName("height")]
    public int height { get; set; }

    [JsonPropertyName("weight")]
    public int weight { get; set; }
};